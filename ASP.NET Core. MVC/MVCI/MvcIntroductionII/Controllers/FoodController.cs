using Microsoft.AspNetCore.Mvc;

namespace MvcIntroductionII.Controllers
{
    
    public class FoodController : Controller
    {
        // [HttpGet("Other/{Food}/{Quantity}")]
        // public string OtherMethod( string Food, int Quantity){
        //     return $" I want to eat {Quantity} {Food} please!";
        // }

        [HttpGet("Other/{Food}/{Quantity}")]
        public ViewResult OtherMethod( string Food, int Quantity){
            // ViewBag.Items = new {food = Food, quantity = Quantity};

            //Keeping params in ViewBag to render later
            ViewBag.Food = Food;
            ViewBag.Quantity = Quantity;
            return View("Index");
        }
    }
}