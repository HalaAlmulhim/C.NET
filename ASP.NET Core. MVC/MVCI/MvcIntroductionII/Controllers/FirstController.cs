using Microsoft.AspNetCore.Mvc;

namespace MvcIntroductionII.Controllers
{
    
    public class FirstController : Controller
    {
        [HttpGet("")]
        public RedirectToActionResult Method(){
            return RedirectToAction("OtherMethod", "Second", new {Food = "sandwiches", Quantity = 5});
        }

        // [HttpGet("Other}")]
        // public ViewResult OtherMethod(){
        //     return View("Index");
        // }

        // [HttpGet("Other/{Food}/{Quantity}")]
        // public string OtherMethod( string Food, int Quantity){
        //     return $" I want to eat {Quantity} {Food} please!";
        // }

        [HttpGet("test")]
        public ViewResult Test(){
            return View();
        }

        [HttpGet("{response}")]
        public IActionResult Depends(string response){
            if (response == "redirect"){
                return RedirectToAction("Metohd");
            }
            else if(response == "json"){
                return Json(new {myResponse = response});
            }
            return View();
        }
    }
}