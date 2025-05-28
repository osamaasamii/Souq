using Serenity.ComponentModel;

namespace AdminArea.souqcom.Forms;

[FormScript("souqcom.Categorycom")]
[BasedOnRow(typeof(CategorycomRow), CheckNames = true)]
public class CategorycomForm
{
    public string Name { get; set; }
    public string Image { get; set; }
    public string Description { get; set; }
}