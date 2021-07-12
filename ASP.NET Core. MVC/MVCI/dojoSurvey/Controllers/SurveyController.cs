using Microsoft.AspNetCore.Mvc;

namespace dojoSurvey.Controllers
{
    public class SurveyController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View("Form");
        }

        [HttpPost("result")]
        public IActionResult FormSubmit(string name, string loc, string lang, string comment)
        {

            // do somrething with data 
            ViewBag.name = name;
            ViewBag.loc = loc;
            ViewBag.lang = lang;
            ViewBag.comment = comment;
            return View("Display");
        }
    }  
}