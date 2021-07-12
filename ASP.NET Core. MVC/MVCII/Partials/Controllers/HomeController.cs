using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;


namespace Partials.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("")]
        public ViewResult Index(){
            // ViewBag.Time = DateTime.Now;
            // HttpContext.Session.SetString("Username", "j-Dawg");
            // HttpContext.Session.SetInt32("Age", 42);
            // string LocalName = HttpContext.Session.GetString("Username");
            // int? IntVariable = HttpContext.Session.GetInt32("Age");
            TempData["Name"]= "J-Dawg";
            TempData["Age"] = 42;
            ViewBag.Username =TempData["Name"] ;//LocalName
            ViewBag.UserAge = TempData["Age"] ;//IntVariable
            HttpContext.Session.Clear();
            return View();
        }
    }
}
