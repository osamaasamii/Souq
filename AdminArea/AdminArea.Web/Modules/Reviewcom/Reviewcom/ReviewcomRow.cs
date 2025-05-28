using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace AdminArea.Reviewcom;

[ConnectionKey("souq"), Module("Reviewcom"), TableName("Review")]
[DisplayName("Reviewcom"), InstanceName("Reviewcom")]
[ReadPermission("Reviewcom")]
[ModifyPermission("Reviewcom")]
[ServiceLookupPermission("Reviewcom")]
public sealed class ReviewcomRow : Row<ReviewcomRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Name"), QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("Email"), Size(50)]
    public string Email { get => fields.Email[this]; set => fields.Email[this] = value; }

    [DisplayName("Subject"), Size(50)]
    public string Subject { get => fields.Subject[this]; set => fields.Subject[this] = value; }

    [DisplayName("Message")]
    public string Message { get => fields.Message[this]; set => fields.Message[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField Name;
        public StringField Email;
        public StringField Subject;
        public StringField Message;

    }
}