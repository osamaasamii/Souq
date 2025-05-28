﻿using Serenity.ComponentModel;
using System.ComponentModel;

namespace AdminArea.ProductImagescom.Columns;

[ColumnsScript("ProductImagescom.ProductImagescom")]
[BasedOnRow(typeof(ProductImagescomRow), CheckNames = true)]
public class ProductImagescomColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string ProductName { get; set; }
    [EditLink]
    public string Image { get; set; }
}