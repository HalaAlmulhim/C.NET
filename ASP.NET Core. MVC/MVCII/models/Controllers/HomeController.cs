using System;
using models.Models;
using Microsoft.AspNetCore.Mvc;

namespace models.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index(){
            return View();
        }

        [HttpPost("submit")]
        public IActionResult FormSubmit(User thisUser){
            if(ModelState.IsValid){
            return RedirectToAction("Result", thisUser);
            }
            else{
                return View("Index");
            }
        }
        
        [HttpGet("things")]
        public ViewResult Result(User thisUser){
            return View("Result", thisUser);
        }
    }
}