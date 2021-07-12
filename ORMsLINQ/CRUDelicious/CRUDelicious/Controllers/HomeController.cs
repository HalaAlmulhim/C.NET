using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private MyContext DbContext;

        public HomeController(MyContext context)
        {
            DbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.AllDishes = DbContext.Dishes.ToList();
            return View("Index");
        }

        [HttpGet("new")]
        public IActionResult New()
        {
            return View("Create");
        }

        [HttpPost("create")]
        public IActionResult Create(Dish newDish)
        {
            if(ModelState.IsValid)
            {
                DbContext.Add(newDish);
                DbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Create");
            }
        }

        [HttpGet("/dish/{id}")]
        public IActionResult Info(int? id)
        {
            Dish ToDisplay = DbContext.Dishes.FirstOrDefault(i => i.DishId == id);

            if(ToDisplay == null)
            {
                return RedirectToAction("Index");
            }

            return View("Info", ToDisplay);
        }

        [HttpGet("/dish/{id}/edit")]
        public IActionResult Edit(int id)
        {
            Dish dish = DbContext.Dishes.FirstOrDefault(d => d.DishId == id);
            return View("Edit", dish);
        }

        [HttpPost("/dish/{id}/update")]
        public IActionResult Update(int id, Dish food)
        {
            if(ModelState.IsValid)
            {
                Dish dish = DbContext.Dishes.FirstOrDefault(i => i.DishId == id);
                dish.Name = food.Name;
                dish.Chef = food.Chef;
                dish.Calories = food.Calories;
                dish.Tastiness = food.Tastiness;
                dish.Description = food.Description;
                dish.UpdatedAt = DateTime.Now;
                DbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                food.DishId = id;
                return View("Edit", food);
            }
        }

        [HttpGet("/dish/{id}/delete")]
        public IActionResult Delete (int id)
        {
            Dish ToDelete = DbContext.Dishes.FirstOrDefault(i => i.DishId == id);
            DbContext.Remove(ToDelete);
            DbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
