using Microsoft.AspNetCore.Mvc;

namespace Razor_Fun.Controllers
{
    public class FoodController : Controller
    {
    [HttpGet("")]
        public ViewResult List()
        {
            return View("FoodList");
        }
    }
}