using KTANE_Diffuser_Winforms.Modules;

namespace KTANE_Diffuser_Winforms.Forms;

public partial class frmKnob : ModuleForm
{
    public frmKnob()
    {
        InitializeComponent();
    }

    private void btnSolve_Click(object sender, EventArgs e)
    {
        // Use an array to store the state of each LED checkbox
        bool[] leds = [
          checkBox1.Checked,
          checkBox2.Checked,
          checkBox3.Checked,
          checkBox4.Checked,
          checkBox5.Checked,
          checkBox6.Checked,
          checkBox7.Checked,
          checkBox8.Checked,
          checkBox9.Checked,
          checkBox10.Checked,
          checkBox11.Checked,
          checkBox12.Checked
      ];

		Knob module = new Knob(leds);
		module.Solve();
    }
}