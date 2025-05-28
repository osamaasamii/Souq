using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using souq.Models;
using System.Diagnostics;

namespace souq.Controllers
{
    public class HomeController : Controller
    {
     
        SouqContext db;
        public HomeController(SouqContext context)
        {
            db = context;
        }

        public IActionResult Index()

        {
            HomeVModel result = new HomeVModel();
            result.Categories = db.Categories.ToList();
            result.Products = db.Products.ToList();
            result.LatestProduct = db.Products.OrderByDescending(x => x.Date).Take(6).ToList();
            
            return View(result);
          
        }


        public IActionResult ImageOfCategory() 
        {
            var result = db.Categories.ToList();

            ViewBag.Prouducts = db.Products.ToList();
            return View(result);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Search(string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                var emptyVM = new SearchVM
                {
                    Products = new List<Product>(),
                    Categories = new List<Category>(),
                    Query = query
                };
                return View(emptyVM);
            }

            var matchedProducts = db.Products
                                    .Where(p => p.Name.Contains(query) || p.Description.Contains(query))
                                    .ToList();

            var matchedCategories = db.Categories
                                      .Where(c => c.Name.Contains(query))
                                      .ToList();

            var vm = new SearchVM
            {
                Products = matchedProducts,
                Categories = matchedCategories,
                Query = query
            };

            return View(vm);
        }




    }
}
