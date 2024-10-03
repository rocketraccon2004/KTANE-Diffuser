using Button = KTANE_Diffuser_Winforms.Modules.Button;
namespace KTANE_Diffuser_Winforms.Forms;

public partial class frmButton : ModuleForm
{
	public Button button;

    public frmButton()
    {
        InitializeComponent();
    }

    private void solve(object sender, EventArgs e)
    {
		button = new Button(dropDownColour.Text, dropDownText.Text);
		button.Solve();
    }
}