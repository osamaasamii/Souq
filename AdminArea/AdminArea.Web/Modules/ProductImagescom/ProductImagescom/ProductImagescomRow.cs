using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace AdminArea.ProductImagescom;

[ConnectionKey("souq"), Module("ProductImagescom"), TableName("ProductImages")]
[DisplayName("Product Imagescom"), InstanceName("Product Imagescom")]
[ReadPermission("ProductImagescom")]
[ModifyPermission("ProductImagescom")]
[ServiceLookupPermission("ProductImagescom")]
public sealed class ProductImagescomRow : Row<ProductImagescomRow.RowFields>, IIdRow, INameRow
{
    const string jProduct = nameof(jProduct);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Product"), ForeignKey(typeof(Productcom.ProductcomRow)), LeftJoin(jProduct), TextualField(nameof(ProductName))]
    [ServiceLookupEditor(typeof(Productcom.ProductcomRow))]
    public int? ProductId { get => fields.ProductId[this]; set => fields.ProductId[this] = value; }

    [DisplayName("Image"), QuickSearch, NameProperty]
    public string Image { get => fields.Image[this]; set => fields.Image[this] = value; }

    [DisplayName("Product Name"), Origin(jProduct, nameof(Productcom.ProductcomRow.Name))]
    public string ProductName { get => fields.ProductName[this]; set => fields.ProductName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public Int32Field ProductId;
        public StringField Image;

        public StringField ProductName;
    }
}