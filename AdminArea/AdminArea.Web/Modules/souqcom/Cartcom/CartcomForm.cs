using Serenity.ComponentModel;

namespace AdminArea.souqcom.Forms;

[FormScript("souqcom.Cartcom")]
[BasedOnRow(typeof(CartcomRow), CheckNames = true)]
public class CartcomForm
{
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public int Qty { get; set; }
}