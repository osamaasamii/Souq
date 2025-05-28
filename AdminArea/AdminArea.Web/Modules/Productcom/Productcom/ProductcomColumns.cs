using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace AdminArea.Productcom.Columns;

[ColumnsScript("Productcom.Productcom")]
[BasedOnRow(typeof(ProductcomRow), CheckNames = true)]
public class ProductcomColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Image { get; set; }
    public string CategoryName { get; set; }
    public DateTime Date { get; set; }
}