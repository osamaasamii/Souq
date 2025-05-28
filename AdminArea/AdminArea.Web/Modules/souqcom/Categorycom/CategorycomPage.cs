using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminArea.souqcom.Pages;

[PageAuthorize(typeof(CategorycomRow))]
public class CategorycomPage : Controller
{
    [Route("souqcom/Categorycom")]
    public ActionResult Index()
    {
        return this.GridPage<CategorycomRow>("@/souqcom/Categorycom/CategorycomPage");
    }
}