using KTANE_Diffuser_Winforms.Modules;

namespace KTANE_Diffuser_Winforms.Forms;

public partial class frmWires : ModuleForm
{
	private string[] wires;

	public frmWires()
    {
        InitializeComponent();
    }

	private void btnSolve_Click(object sender, EventArgs e)
	{
		wires = new string[]
		{
			comboBox1.Text,
			comboBox2.Text,
			comboBox3.Text,
			comboBox4.Text,
			comboBox5.Text,
			comboBox6.Text
		};

		Wires module = new Wires(wires);
		module.Solve();
	}
}