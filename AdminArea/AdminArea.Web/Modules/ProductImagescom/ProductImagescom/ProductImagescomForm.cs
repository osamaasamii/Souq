using Serenity.ComponentModel;

namespace AdminArea.ProductImagescom.Forms;

[FormScript("ProductImagescom.ProductImagescom")]
[BasedOnRow(typeof(ProductImagescomRow), CheckNames = true)]
public class ProductImagescomForm
{
    public int ProductId { get; set; }
    public string Image { get; set; }
}