namespace KTANE_Diffuser_Winforms.Forms;

public partial class frmKnob : ModuleForm
{
    public frmKnob()
    {
        InitializeComponent();
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        Program.switchForm(Utils.getMainForm());
    }

    private void btnStrike_Click(object sender, EventArgs e)
    {
        if (ModifierKeys.HasFlag(Keys.Shift))
        {
            Assistant.instance.strikes--;
            return;
        }
        Assistant.instance.strikes++;
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

        // Define conditions for each direction
        bool up = (!leds[0] && leds[1] && !leds[2] && leds[3] && leds[4] && leds[5] && !leds[6] && leds[7] && leds[8] && !leds[9] && leds[10] && leds[11]) ||
          (leds[0] && !leds[1] && !leds[2] && leds[3] && leds[4] && leds[5] && !leds[6] && !leds[7] && leds[8] && leds[9] && !leds[10] && leds[11]);

        bool down = (!leds[0] && leds[1] && leds[2] && leds[3] && leds[4] && leds[5] && !leds[6] && leds[7] && !leds[8] && !leds[9] && leds[10] && leds[11]) ||
          (leds[0] && !leds[1] && !leds[2] && leds[3] && leds[4] && !leds[5] && !leds[6] && !leds[7] && leds[8] && !leds[9] && !leds[10] && leds[11]);

        bool left = (!leds[0] && leds[1] && !leds[2] && !leds[3] && !leds[4] && !leds[5] && !leds[6] && leds[7] && leds[8] && leds[9] && !leds[10] && leds[11]) ||
          (!leds[0] && !leds[1] && !leds[2] && !leds[3] && !leds[4] && !leds[5] && !leds[6] && leds[7] && leds[8] && leds[9] && !leds[10] && !leds[11]);

        bool right = (leds[0] && leds[1] && !leds[2] && leds[3] && leds[4] && leds[5] && leds[6] && !leds[7] && leds[8] && leds[9] && leds[10] && !leds[11]) ||
          (leds[0] && leds[1] && !leds[2] && leds[3] && leds[4] && leds[5] && leds[6] && !leds[7] && !leds[8] && leds[9] && !leds[10] && !leds[11]);

        if (up)
        {
            MessageBox.Show("Up");
        }

        if (down)
        {
            MessageBox.Show("Down");
        }

        if (left)
        {
            MessageBox.Show("Left");
        }

        if (right)
        {
            MessageBox.Show("Right");
        }

        Program.switchForm(Utils.getMainForm());
    }
}