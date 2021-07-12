using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProductsAndCategories.Models;

namespace ProductsAndCategories.Controllers
{
    public class HomeController : Controller
    {
        private ProductsAndCategoriesContext DbContext;
        public HomeController(ProductsAndCategoriesContext context)
        {
            DbContext = context;
        }

        [HttpGet("")]
        public IActionResult Product()
        {
            ViewBag.allProducts = DbContext.Products.ToList();
            
            return View();
        }


        [HttpPost("")]
        public IActionResult AddProduct( Product newProduct )
        {
            if (ModelState.IsValid)
            {
                DbContext.Products.Add(newProduct);
                DbContext.SaveChanges();
                return RedirectToAction("Product");
            }
            else
            {
                ViewBag.allProducts = DbContext.Products.ToList();
                return View("Product");
            }
        }


        [HttpGet("product/{id}")]
        public IActionResult ProductDetails(int id)
        {

            Product selectedProduct = DbContext.Products
            .Include( p => p.CategoriesOfProduct )
            .ThenInclude( cp => cp.CategoryOfProduct )
            .FirstOrDefault( p => p.ProductId == id);


            ViewBag.CategoiresNotInProduct = DbContext.Categories
                .Include( c => c.ProductsOfCategory )
                .ThenInclude( pc => pc.ProductInCategory )
                .Where( c => ! c.ProductsOfCategory.Any( p => p.ProductInCategory.ProductId == id ))
                .ToList();

            return View(selectedProduct);
        }


        [HttpPost("product/{prudId}/addcat")]
        public IActionResult AddToCategory(int prudId, int catId)
        {
            Store newStore = new Store();
            newStore.CategoryId = catId;
            newStore.ProductId = prudId;

            DbContext.Stores.Add(newStore);
            DbContext.SaveChanges();
            return Redirect("/product/"+prudId);
        }



        [HttpGet("category")]
        public IActionResult Category()
        {
            ViewBag.allCategories = DbContext.Categories.ToList();
            
            return View();
        }


        [HttpPost("category")]
        public IActionResult AddCategory( Category newCategory )
        {
            if (ModelState.IsValid)
            {
                DbContext.Categories.Add(newCategory);
                DbContext.SaveChanges();
                return RedirectToAction("Category");
            }
            else
            {
                ViewBag.allCategories = DbContext.Categories.ToList();
                return View("Category");
            }
        }


        [HttpGet("category/{id}")]
        public IActionResult CategoryDetails(int id)
        {

            Category selectedCategory= DbContext.Categories
                .Include( c => c.ProductsOfCategory )
                .ThenInclude( pc => pc.ProductInCategory )
                .FirstOrDefault( c => c.CategoryId == id);


            ViewBag.ProductsNotInCategory = DbContext.Products
                .Include( p => p.CategoriesOfProduct )
                .ThenInclude( cp => cp.CategoryOfProduct )
                .Where( p => ! p.CategoriesOfProduct.Any( p => p.CategoryOfProduct.CategoryId == id ))
                .ToList();

            return View(selectedCategory);
        }


        [HttpPost("category/{catId}/addprod")]
        public IActionResult AddProdToCategory(int prodId, int catId)
        {
            Store newStore = new Store();
            newStore.CategoryId = catId;
            newStore.ProductId = prodId;

            DbContext.Stores.Add(newStore);
            DbContext.SaveChanges();
            return Redirect("/category/"+catId);
        }


    }
}
