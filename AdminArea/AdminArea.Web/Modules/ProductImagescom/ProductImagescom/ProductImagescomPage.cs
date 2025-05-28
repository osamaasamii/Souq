using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminArea.ProductImagescom.Pages;

[PageAuthorize(typeof(ProductImagescomRow))]
public class ProductImagescomPage : Controller
{
    [Route("ProductImagescom/ProductImagescom")]
    public ActionResult Index()
    {
        return this.GridPage<ProductImagescomRow>("@/ProductImagescom/ProductImagescom/ProductImagescomPage");
    }
}