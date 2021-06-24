using Microsoft.AspNetCore.Mvc;

namespace MvclntroductinI.Controllers
{
    public class HelloController: Controller
    {
        [HttpGet ("")]
        // public string Index(){
        //     return "Hello World from HelloController!";
        // }
        public ViewResult Index(){
            return View();
        }

        [HttpGet("pizza")]
        public string pizza(){
            return "Pizza Time!";
        }

        [HttpGet("pizza/yuck")]
        public string PizzaYuck(){
            return " I hate pizza!!";
        }

        [HttpGet("pizza/{topping}")]
        public string pizza( string topping){
            return $"{topping} Pizza Time!";
        }

        // [HttpGet("pizza/{num}")]
        // public string NumPizzas(int num){
        //     return $"We ordered  {num} pizzas!";
        // }
    }
}