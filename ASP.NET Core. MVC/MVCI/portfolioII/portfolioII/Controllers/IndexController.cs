using System;
using Microsoft.AspNetCore.Mvc;

namespace portfolioII.Controllers
{
    public class IndexController : Controller // i was adding s in the name of class ;( "remmber i should be the same class name"
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet("projects")]
        public ViewResult Projects()
        {
            return View();
        }

        [HttpGet]
        [Route("contact")]
        public ViewResult Contact()
        {
            return View();
        }
        
    }
}