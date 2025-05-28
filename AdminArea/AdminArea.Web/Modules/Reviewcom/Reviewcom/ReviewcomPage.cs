using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminArea.Reviewcom.Pages;

[PageAuthorize(typeof(ReviewcomRow))]
public class ReviewcomPage : Controller
{
    [Route("Reviewcom/Reviewcom")]
    public ActionResult Index()
    {
        return this.GridPage<ReviewcomRow>("@/Reviewcom/Reviewcom/ReviewcomPage");
    }
}