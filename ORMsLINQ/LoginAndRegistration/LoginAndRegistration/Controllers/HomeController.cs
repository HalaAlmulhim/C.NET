using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LoginAndRegistration.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace LoginAndRegistration.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public ViewResult Register()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult RegisterForm(User user)
        {
            if(ModelState.IsValid)
            {
                if(_context.Users.Any(i => i.Email == user.Email))
                {
                    ModelState.AddModelError("Email", "Email is already in Use! Try Another one");
                    return View("Register");
                }
                else
                {
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);
                _context.Users.Add(user);
                _context.SaveChanges();
                HttpContext.Session.SetInt32("userId", user.UserId); // add seesion
                return RedirectToAction("Success");
                }
            }
            else
            {
            return View("Register");
            }
        }

         [HttpGet("login")]
        public ViewResult Login()
        {
            return View();
        }

        [HttpPost("login")]
        public IActionResult LoginForm(LoginUser log_in)
        {
            if(ModelState.IsValid)
            {
                User db_user = _context.Users.FirstOrDefault(i => i.Email == log_in.LoginEmail);
                if(db_user == null)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid Email! Try Another one");
                    return View("Login");
                }
                else
                {
                    PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
                    var result = hasher.VerifyHashedPassword(log_in, db_user.Password, log_in.LoginPassword);
                    if(result == 0)
                    {
                        ModelState.AddModelError("LoginPassword", "Invalid Password! Try Again");
                        return View("Login");
                    }
                    else
                    {
                    HttpContext.Session.SetInt32("userId", db_user.UserId); // add session
                    return RedirectToAction("Success");
                    }
            }    }
            else
            { 
                return View("Login");
            }
        }

        [HttpGet("success")]
        public IActionResult Success()
        {
            int? userId = HttpContext.Session.GetInt32("userId");
            if(userId == null)
            {
                return RedirectToAction("Register");
            }
            User user = _context.Users.FirstOrDefault(i => i.UserId == userId);
            return View("Success");
        }


        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
