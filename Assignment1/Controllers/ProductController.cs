using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment1.Models;


namespace Assignment1.Controllers
{
    public class ProductController : Controller
    {
        public static List<Product> list = new List<Product>();
        [Route("ProductDetail")]
        public IActionResult Index()
        {
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product p)
        {
            if (ModelState.IsValid)
            {
                list.Add(p);
                return RedirectToAction("Index");
            }
            else
                return View();
        }
    }
}
