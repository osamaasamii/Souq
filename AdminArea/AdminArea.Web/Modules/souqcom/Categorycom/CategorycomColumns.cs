using Serenity.ComponentModel;
using System.ComponentModel;

namespace AdminArea.souqcom.Columns;

[ColumnsScript("souqcom.Categorycom")]
[BasedOnRow(typeof(CategorycomRow), CheckNames = true)]
public class CategorycomColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Name { get; set; }
    public string Image { get; set; }
    public string Description { get; set; }
}