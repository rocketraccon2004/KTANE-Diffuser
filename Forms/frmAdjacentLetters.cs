using KTANE_Diffuser_Winforms.Modules;

namespace KTANE_Diffuser_Winforms.Forms;

public partial class frmAdjacentLetters : ModuleForm
{
	new AdjacentLetters module;
	public frmAdjacentLetters()
    {
		module = new AdjacentLetters();
		InitializeComponent();
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        Program.switchForm(Utils.getMainForm());
    }

    private void btnSolve_Click(object sender, EventArgs e)
    {
		module.txts = new List<TextBox>()
		{
			txt11,
			txt12,
			txt13,
			txt14,
			txt21,
			txt22,
			txt23,
			txt24,
			txt31,
			txt32,
			txt33,
			txt34
		};
		module.Solve();
    }    

    private void btnReset_Click(object sender, EventArgs e)
    {
		module.reset();
    }
}
