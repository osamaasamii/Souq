using Microsoft.AspNetCore.Mvc;
using souq.Models;
using System.Linq;

namespace souq.Controllers
{
    [Route("[controller]/[action]")]

    public class ReviewController : Controller
    {
        private readonly SouqContext db;

        public ReviewController(SouqContext context)
        {
            db = context;
        }

        // GET: عرض الريفيوز والفورم معاً
        [HttpGet]
        public IActionResult Review()
        {
            var vm = new ViewModelReview
            {
                Reviews = db.Reviews.ToList(),
                NewReview = new Review()
            };
            return View(vm);
        }
        // POST: استلام الريفيو الجديد

        [HttpPost]
        [HttpPost]
        public IActionResult Review(ViewModelReview model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Reviews.Add(model.NewReview);
                    db.SaveChanges();

                    ViewBag.SuccessMessage = "Your review has been sent successfully. You can submit a new review below.";

                    // ✅ حدّث الريفيوهات بعد الحفظ
                    model.Reviews = db.Reviews.ToList();

                    // ✅ بعد كده فرّغ النموذج
                    model.NewReview = new Review();

                    return View(model);
                }
                catch (Exception ex)
                {
                    ViewBag.ErrorMessage = "There was a problem saving your review. Please try again.";
                }
            }
            else
            {
                ViewBag.ErrorMessage = "Please correct the errors below.";
            }

            // ✅ ضروري تتأكد إن الريفيوهات موجودة حتى لو فيه خطأ
            model.Reviews = db.Reviews.ToList();
            return View(model);
        }



    }
}
