using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminArea.Productcom.Pages;

[PageAuthorize(typeof(ProductcomRow))]
public class ProductcomPage : Controller
{
    [Route("Productcom/Productcom")]
    public ActionResult Index()
    {
        return this.GridPage<ProductcomRow>("@/Productcom/Productcom/ProductcomPage");
    }
}