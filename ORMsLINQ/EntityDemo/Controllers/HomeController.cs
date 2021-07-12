using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EntityDemo.Models;

namespace EntityDemo.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _Context;
        public HomeController(MyContext context){
            _Context = context;
        }

        [HttpGet("")]
        public ViewResult Index(){
            List<User> AllUsers = _Context.Users.ToList();
            ViewBag.UserList = AllUsers;
            return View();
        }

        [HttpPost("create")]
        public IActionResult CreateUser(User newUser){
            if(ModelState.IsValid){
                _Context.Add(newUser);
                _Context.SaveChanges();
                return RedirectToAction("Index");
            }
            else{
                return View("Index");
            }
        }
    }
}
