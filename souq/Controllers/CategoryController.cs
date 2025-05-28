using Microsoft.AspNetCore.Mvc;
using souq.Models;

namespace souq.Controllers
{
    public class CategoryController : Controller
    {
        SouqContext db;
        public CategoryController(SouqContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            var Category = db.Categories.ToList();
            return View(Category);
         
        }
    }
}
