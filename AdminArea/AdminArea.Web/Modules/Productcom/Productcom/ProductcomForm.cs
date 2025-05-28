using Serenity.ComponentModel;
using System;

namespace AdminArea.Productcom.Forms;

[FormScript("Productcom.Productcom")]
[BasedOnRow(typeof(ProductcomRow), CheckNames = true)]
public class ProductcomForm
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Image { get; set; }
    public int CategoryId { get; set; }
    public DateTime Date { get; set; }
}