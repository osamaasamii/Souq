using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace AdminArea.souqcom;

[ConnectionKey("souq"), Module("souqcom"), TableName("Category")]
[DisplayName("Categorycom"), InstanceName("Categorycom")]
[ReadPermission("Categorycom")]
[ModifyPermission("Categorycom")]
[ServiceLookupPermission("Categorycom")]
public sealed class CategorycomRow : Row<CategorycomRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Name"), QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("Image")]
    public string Image { get => fields.Image[this]; set => fields.Image[this] = value; }

    [DisplayName("Description")]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField Name;
        public StringField Image;
        public StringField Description;

    }
}