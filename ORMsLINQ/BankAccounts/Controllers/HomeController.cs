using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BankAccounts.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace BankAccounts.Controllers
{
    public class HomeController : Controller
    {
        private BankAccountsContext DbContext;
        public HomeController(BankAccountsContext context)
        {
            DbContext = context;
        }


        [HttpGet("")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult RegisterUser(User newUser)
        {
            if(ModelState.IsValid)
            {
                if (DbContext.Users.Any( u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Register");
                }
                else
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                    DbContext.Add(newUser);
                    DbContext.SaveChanges();
                    HttpContext.Session.SetInt32("userId", newUser.UserId);
                    return RedirectToAction("Account", new {id = newUser.UserId});
                }
            }
            else
            {
                return View("Register");
            }
        }
        


        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("login")]
        public IActionResult UserLogin(LoginUser user)
        {
            if (ModelState.IsValid)
            {
                User userInDb = DbContext.Users.FirstOrDefault( u => u.Email == user.Email );

                if (userInDb == null)
                {
                    ModelState.AddModelError("Email", "Inalid Credentials");
                    return View("Login");
                }
                else
                {
                    PasswordHasher<LoginUser> Hasher = new PasswordHasher<LoginUser>();
                    var results = Hasher.VerifyHashedPassword(user, userInDb.Password, user.Password);
                    
                    if (results == 0)
                    {
                        ModelState.AddModelError("Email", "Inalid Credentials");
                        return View("Login");
                    }
                    else
                    {
                        HttpContext.Session.SetInt32("userId", userInDb.UserId);
                        return RedirectToAction("Account", new {id = userInDb.UserId});
                    }

                }
            }
            else
            {
                return View("Login");
            }
        }

        
        [HttpGet("account/{id}")]
        public IActionResult Account(int id)
        {
            if ( HttpContext.Session.GetInt32("userId") == null || HttpContext.Session.GetInt32("userId") != id )
            {
                return RedirectToAction("Login");
            }
            else
            {
                User user = DbContext.Users.Include( t => t.UserTransactions ).FirstOrDefault( u => u.UserId == id );
                if (user == null)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    double balance = 0;
                    foreach( Transaction tran in user.UserTransactions )
                    {
                        balance += tran.Amount;
                    }

                    ViewBag.User = user;
                    ViewBag.Balance = balance;

                    if (TempData["Err"] != null)
                    {
                        ModelState.AddModelError("Amount", "This Field Cannot be Empty");
                    }
                    if (TempData["ErrBalance"] != null)
                    {
                        ModelState.AddModelError("Amount", "Insufficient balance");
                    }

                    return View();
                }
                
            }
        }


        [HttpPost("trarnsaction")]
        public IActionResult DepositWithdraw(Transaction newTrans)
        {
            
            int? userId = HttpContext.Session.GetInt32("userId");
            if (userId != null)
            {   
                if (ModelState.IsValid)
                {
                    User user = DbContext.Users.Include( t => t.UserTransactions ).FirstOrDefault( u => u.UserId == (int)userId );
                    double balance = 0;
                    foreach( Transaction tran in user.UserTransactions )
                    {
                        balance += tran.Amount;
                    }

                    newTrans.UserId = (int)userId;

                    if (newTrans.Amount + balance < 0)
                    {
                        TempData["ErrBalance"] = true;
                        return RedirectToAction("Account", new {id = userId});
                    }

                    DbContext.Add(newTrans);
                    DbContext.SaveChanges();
                    return RedirectToAction("Account", new {id = userId});
                }
                else
                {
                    TempData["Err"] = true;
                    return RedirectToAction("Account", new {id = userId});
                }
            }
            else
            {
                return RedirectToAction("Login");
            }
            
            
        }
        





    }
}
