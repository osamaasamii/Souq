using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using souq.Models;

namespace souq.Controllers
{
    public class ProductController : Controller
    {

        SouqContext db;
        public ProductController(SouqContext context)
        {
            db = context;
        }
        public IActionResult AllProduct(int id)

        {
            var products = db.Products.Where(p => p.CategoryId == id).ToList();
            return View(products);
        }

        public IActionResult Currentproduct(int id )
        {
            var products = db.Products.Include(x =>x .Category).Include(x =>x .ProductImages).FirstOrDefault(x => x.Id == id );    
            return View(products);

        }
    }
}
