using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WeddingPlanner.Models;

namespace WeddingPlanner.Controllers
{
    public class HomeController : Controller
    {
        private WeddingPlannerContext DbContext;
        public HomeController(WeddingPlannerContext context)
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
                    return RedirectToAction("Dashboard", "Wedding");
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
                        return RedirectToAction("Dashboard", "Wedding");
                    }

                }
            }
            else
            {
                return View("Login");
            }
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
