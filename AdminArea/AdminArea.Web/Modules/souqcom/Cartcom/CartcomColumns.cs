using Serenity.ComponentModel;
using System.ComponentModel;

namespace AdminArea.souqcom.Columns;

[ColumnsScript("souqcom.Cartcom")]
[BasedOnRow(typeof(CartcomRow), CheckNames = true)]
public class CartcomColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public int UserId { get; set; }
    public string ProductName { get; set; }
    public int Qty { get; set; }
}