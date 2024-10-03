#pragma warning disable CS8602 // Dereference of a possibly null reference.
using KTANE_Diffuser_Winforms.Modules;

namespace KTANE_Diffuser_Winforms.Forms;

public partial class frmAdventureGame : ModuleForm
{
	new AdventureGame module = new AdventureGame();

	public frmAdventureGame()
	{
		InitializeComponent();
		ddMonster.SelectedIndex = 0;
	}



	private void frmAdventureGame_Load(object sender, EventArgs e)
	{
		MessageBox.Show("Use the potion");
	}

	private void btnSolve_Click(object sender, EventArgs e)
	{
		module.setStats(txtSTR.Text, txtDEX.Text,
			txtINT.Text, txtHeight.Text, txtHeightInches.Text,
			txtTemperature.Text, txtGravity.Text, txtPressure.Text, ddMonster.Text);

		module.setWeapons(cbBroadsword.Checked, cbCaber.Checked, cbNastyKnife.Checked, cbLongbow.Checked, cbMagicOrb.Checked, cbGrimoire.Checked);
		module.setItems(cbBalloon.Checked, cbBattery.Checked, cbBellows.Checked, cbCrystalBall.Checked,
			cbFeather.Checked, cbHardDrive.Checked, cbLamp.Checked,
			cbMoonstone.Checked, cbSmallDog.Checked, cbStepladder.Checked,
			cbSunstone.Checked, cbSymbol.Checked, cbTicket.Checked,
			cbTrophy.Checked);
		module.Solve();
	}
}