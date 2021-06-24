using Microsoft.AspNetCore.Mvc;

namespace forms.Controllers
{
    public class FormController : Controller
    {
        [HttpGet ("formSubmit")]
        public IActionResult FormSubmit(string TextField, int NumberField){

            //do stuff with the variables
            return RedirectToAction("Index", "Home");
        }

        [HttpGet("form")]
        public IActionResult Index(){
            return View();
        }
    }
}