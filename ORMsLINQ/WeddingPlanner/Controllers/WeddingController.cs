using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WeddingPlanner.Models;


namespace WeddingPlanner.Controllers
{
    public class WeddingController : Controller
    {

        private WeddingPlannerContext DbContext;
        public WeddingController(WeddingPlannerContext context)
        {
            DbContext = context;
        }


        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetInt32("userId") != null)
            {
                List<Wedding> allWeddings = DbContext.Weddeings
                    .Include( w => w.Guests )
                    .ThenInclude( g => g.WeddingGuest )
                    .ToList();
                ViewBag.LoggedInUser = HttpContext.Session.GetInt32("userId");
                return View(allWeddings);
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
        }


        [HttpGet("new")]
        public IActionResult NewWedding()
        {   
            if (HttpContext.Session.GetInt32("userId") != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
        }

        [HttpPost("createwedding")]
        public IActionResult CreateWedding(Wedding newWedding)
        {
            if (HttpContext.Session.GetInt32("userId") != null)
            {
                if (ModelState.IsValid)
                {
                    newWedding.UserId = (int)HttpContext.Session.GetInt32("userId");
                    DbContext.Weddeings.Add(newWedding);
                    DbContext.SaveChanges();
                    return RedirectToAction("Dashboard"); 
                }
                else
                {
                    return View("NewWedding");
                }
                
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
        }

        [HttpGet("delete/{wedId}")]
        public IActionResult DeleteWedding(int wedId)
        {
            int? loggedUser = HttpContext.Session.GetInt32("userId");

            if (loggedUser != null)
            {
                Wedding wed = DbContext.Weddeings
                            .Include( w => w.Creator )
                            .FirstOrDefault( w => w.UserId == loggedUser && w.WeddingId == wedId );

                if (wed != null)
                {
                    
                    DbContext.Remove(wed);
                    DbContext.SaveChanges();

                }
                
                return RedirectToAction("Dashboard");
            }
            else
            {
                return RedirectToAction("Dashboard");
            }
        }


        [HttpGet("rsvp/{wedId}")]
        public IActionResult RSVP(int wedId)
        {
            if (HttpContext.Session.GetInt32("userId") != null)
            {
                Reservation newRes = new Reservation();
                newRes.UserId = (int)HttpContext.Session.GetInt32("userId");
                newRes.WeddingId = wedId;
                DbContext.Reservations.Add(newRes);
                DbContext.SaveChanges();
                return RedirectToAction("Dashboard");
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
        }


        [HttpGet("unrsvp/{wedId}")]
        public IActionResult UnRSVP(int wedId)
        {
            if (HttpContext.Session.GetInt32("userId") != null)
            {
                int userId = (int)HttpContext.Session.GetInt32("userId");
                Reservation res = DbContext.Reservations
                    .Include( w => w.UserWedding )
                    .ThenInclude( u => u.Guests )
                    .FirstOrDefault( r => r.UserId == userId && r.WeddingId == wedId );
                DbContext.Reservations.Remove(res);
                DbContext.SaveChanges();
                return RedirectToAction("Dashboard");
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
        }


        [HttpGet("wedding/{wedId}")]
        public IActionResult WeddingDetailes(int wedId)
        {
            if (HttpContext.Session.GetInt32("userId") != null)
            {
                Wedding wed = DbContext.Weddeings
                .Include( u => u.Guests )
                .ThenInclude( g => g.WeddingGuest )
                .FirstOrDefault( w => w.WeddingId == wedId);
                return View(wed);
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
        }
    }
}