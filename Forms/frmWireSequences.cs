using KTANE_Diffuser_Winforms.Modules;

namespace KTANE_Diffuser_Winforms.Forms;
public partial class frmWireSequences : ModuleForm
{
	WireSequences module;
    public frmWireSequences()
    {
        InitializeComponent();
		module = new WireSequences();
    }

    private void btnSolve_Click(object sender, EventArgs e)
    {
		string colour1 = cbWire1Colour.Text;
		string colour2 = cbWire2Colour.Text;
		string colour3 = cbWire3Colour.Text;

		string letter1 = cbWire1End.Text;
		string letter2 = cbWire2End.Text;
		string letter3 = cbWire3End.Text;

		module.setWires(colour1, colour2, colour3, letter1, letter2, letter3);
		module.Solve();
	}
}