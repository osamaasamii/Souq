using Serenity.ComponentModel;

namespace AdminArea.Reviewcom.Forms;

[FormScript("Reviewcom.Reviewcom")]
[BasedOnRow(typeof(ReviewcomRow), CheckNames = true)]
public class ReviewcomForm
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Subject { get; set; }
    public string Message { get; set; }
}