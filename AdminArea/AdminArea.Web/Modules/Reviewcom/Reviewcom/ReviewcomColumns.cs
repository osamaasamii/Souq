using Serenity.ComponentModel;
using System.ComponentModel;

namespace AdminArea.Reviewcom.Columns;

[ColumnsScript("Reviewcom.Reviewcom")]
[BasedOnRow(typeof(ReviewcomRow), CheckNames = true)]
public class ReviewcomColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Name { get; set; }
    public string Email { get; set; }
    public string Subject { get; set; }
    public string Message { get; set; }
}