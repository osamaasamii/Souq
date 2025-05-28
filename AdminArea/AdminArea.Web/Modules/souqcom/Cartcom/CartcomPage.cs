using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminArea.souqcom.Pages;

[PageAuthorize(typeof(CartcomRow))]
public class CartcomPage : Controller
{
    [Route("souqcom/Cartcom")]
    public ActionResult Index()
    {
        return this.GridPage<CartcomRow>("@/souqcom/Cartcom/CartcomPage");
    }
}