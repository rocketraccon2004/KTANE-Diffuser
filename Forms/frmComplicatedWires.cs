using KTANE_Diffuser_Winforms.Modules;

namespace KTANE_Diffuser_Winforms.Forms;

public partial class frmComplicatedWires : ModuleForm
{
	ComplicatedWires module;
    public frmComplicatedWires()
    {
        InitializeComponent();
    }

    private void btnSolve_Click(object sender, EventArgs e)
    {
		module = new ComplicatedWires(cbRedWire.Checked, cbBlueWire.Checked, cbLED.Checked, cbStar.Checked);
		module.Solve();
	}
}
