using Microsoft.AspNetCore.Mvc;

namespace PortfolioI.Controllers
{
    public class PotfolioController
    {
        //localhost:5000
        [HttpGet("")]
        public string Index(){
            return "This is my Index!";
        }

        //localhost:5000/projects
        [HttpGet("/projects")]
        public string projects(){
            return "This is my projects!!";
        }

        //localhost:5000/contact
        [HttpGet("/contact")]
        public string Contact()
        {
            return "This is my Contacts!";
        }
    }
}