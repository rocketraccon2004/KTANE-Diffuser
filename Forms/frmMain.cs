using Newtonsoft.Json;

namespace KTANE_Diffuser_Winforms.Forms;

#pragma warning disable CS8604 // Possible null reference argument.
public partial class frmMain : ModuleForm
{
    public frmMain()
    {
        InitializeComponent();
        btnSolve.Visible = false;
        btnBack.Visible = false;
    }

    private void saveEdgeworkButton_Click(object sender, EventArgs e)
    {
        string json = JsonConvert.SerializeObject(Assistant.instance.bomb);
        File.WriteAllText("Edgework.json", json);
    }

    private void btnChangeEdgework_Click(object sender, EventArgs e)
    {
        Assistant.instance.strikes = 0;
        Program.switchForm(Utils.SelectModuleForm("Edgework Input"));
    }

    private void btnStrike_click(object sender, EventArgs e)
    {
        if (ModifierKeys.HasFlag(Keys.Shift))
        {
            Assistant.instance.strikes--;
            return;
        }
        Assistant.instance.strikes++;
    }

    private void btnSelect_Click(object sender, EventArgs e)
    {
        Program.switchForm(Utils.SelectModuleForm(dropDownModules.Text));
    }
}