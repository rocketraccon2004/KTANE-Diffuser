using KTANE_Diffuser_Winforms.Modules;
using Microsoft.VisualBasic;

namespace KTANE_Diffuser_Winforms.Forms;

public partial class ModuleForm : Form { 

	public ModuleForm()
	{
		InitializeComponent();
	}

	private void ModuleForm_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (Visible)
		{
			string message = "Are you sure you want to quit the program?";
			string caption = "Quit Program";

			DialogResult result = MessageBox.Show(
				message,
				caption,
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question
			);

			//if the user clicks no, don't close the program
			if (result == DialogResult.No)
			{
				e.Cancel = true;
			}
			else
			{
				Visible = false;
				Application.Exit();
			}
		}
	}

	public void disableButtons()
	{
		btnBack.Visible = false;
		btnSolve.Visible = false;
		btnStrike.Visible = false;
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
			MessageBox.Show("Removed a Strike");
			return;
		}
		Assistant.instance.strikes++;
		MessageBox.Show("Added a Strike");
	}
}