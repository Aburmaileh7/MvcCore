using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcCore.Models;

namespace MvcCore.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductController

        public List<Product> Products { get; set; }

        public ActionResult Index()
        {

            if (Products == null || Products.Count == 0){

                Products = new List<Product>();

              Products.Add(new Product { Id = 1, ProductName = "Iphone 15", ProductNumber = "p123" });
                Products.Add(new Product { Id = 2, ProductName = "Samsung s20", ProductNumber = "g1883" });
                Products.Add(new Product { Id = 3, ProductName = "Oppo", ProductNumber = "V-232" });


            }

            
            return View(Products);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            try
            {
                //var products = new List<Product>();

                Products.Add(product);
                




                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
