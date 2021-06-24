using Microsoft.AspNetCore.Mvc;

namespace PorfolioII.Controllers
{
    public class PortfolioController : Controller
    {
        [HttpGet("")]
        public ViewResult Home()
        {
            return View();
        }

        [HttpGet("projects")]
        public ViewResult Projects()
        {
            return View();
        }

        [HttpGet("contact")]
        public ViewResult Contact()
        {
            return View();
        }
    }
}