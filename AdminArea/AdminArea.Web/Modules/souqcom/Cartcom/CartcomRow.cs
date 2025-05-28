using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace AdminArea.souqcom;

[ConnectionKey("souq"), Module("souqcom"), TableName("Cart")]
[DisplayName("Cartcom"), InstanceName("Cartcom")]
[ReadPermission("Cartcom")]
[ModifyPermission("Cartcom")]
public sealed class CartcomRow : Row<CartcomRow.RowFields>, IIdRow
{
    const string jProduct = nameof(jProduct);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("User Id")]
    public int? UserId { get => fields.UserId[this]; set => fields.UserId[this] = value; }

    [DisplayName("Product"), ForeignKey(typeof(Productcom.ProductcomRow)), LeftJoin(jProduct), TextualField(nameof(ProductName))]
    [ServiceLookupEditor(typeof(Productcom.ProductcomRow))]
    public int? ProductId { get => fields.ProductId[this]; set => fields.ProductId[this] = value; }

    [DisplayName("Qty")]
    public int? Qty { get => fields.Qty[this]; set => fields.Qty[this] = value; }

    [DisplayName("Product Name"), Origin(jProduct, nameof(Productcom.ProductcomRow.Name))]
    public string ProductName { get => fields.ProductName[this]; set => fields.ProductName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public Int32Field UserId;
        public Int32Field ProductId;
        public Int32Field Qty;

        public StringField ProductName;
    }
}