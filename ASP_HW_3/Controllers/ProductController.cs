using ASP_HW_3.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_HW_3.Controllers
{
    public class ProductController : Controller
    {
        public static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 25000 },
            new Product { Id = 2, Name = "Phone", Price = 15000 },
            new Product { Id = 3, Name = "Headphones", Price = 2000 }
        };

        public IActionResult Index()
        {
            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            ViewBag.Product = product;

            return View();
        }
    }
}
