using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace AdminArea.Productcom;

[ConnectionKey("souq"), Module("Productcom"), TableName("Product")]
[DisplayName("Productcom"), InstanceName("Productcom")]
[ReadPermission("Productcom")]
[ModifyPermission("Productcom")]
[ServiceLookupPermission("Productcom")]
public sealed class ProductcomRow : Row<ProductcomRow.RowFields>, IIdRow, INameRow
{
    const string jCategory = nameof(jCategory);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Name"), QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("Description")]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("Price"), Size(18)]
    public decimal? Price { get => fields.Price[this]; set => fields.Price[this] = value; }

    [DisplayName("Image")]
    public string Image { get => fields.Image[this]; set => fields.Image[this] = value; }

    [DisplayName("Category"), ForeignKey(typeof(souqcom.CategorycomRow)), LeftJoin(jCategory), TextualField(nameof(CategoryName))]
    [ServiceLookupEditor(typeof(souqcom.CategorycomRow), Service = "souqcom/Categorycom/List")]
    public int? CategoryId { get => fields.CategoryId[this]; set => fields.CategoryId[this] = value; }

    [DisplayName("Date")]
    public DateTime? Date { get => fields.Date[this]; set => fields.Date[this] = value; }

    [DisplayName("Category Name"), Origin(jCategory, nameof(souqcom.CategorycomRow.Name))]
    public string CategoryName { get => fields.CategoryName[this]; set => fields.CategoryName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField Name;
        public StringField Description;
        public DecimalField Price;
        public StringField Image;
        public Int32Field CategoryId;
        public DateTimeField Date;

        public StringField CategoryName;
    }
}