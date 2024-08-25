using Newtonsoft.Json;

namespace KTANE_Diffuser_Winforms.Forms;

public partial class frmMain : Form
{
    public frmMain()
    {
        InitializeComponent();
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
        setModules();
    }

    private void setModules()
    {
        foreach (var s in Assistant.instance.modules) dropDownModules.Items.Add(s);
    }

    private void saveEdgeworkButton_Click(object sender, EventArgs e)
    {
        string json = JsonConvert.SerializeObject(Assistant.instance.bomb);
        File.WriteAllText("Edgework.json", json);
    }

    private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }

    private void btnChangeEdgework_Click(object sender, EventArgs e)
    {
        Assistant.instance.strikes = 0;
        Program.switchForm(new frmEdgeworkInput());
    }

    private void btnStrike_click(object sender, EventArgs e)
    {
        Assistant.instance.strikes++;
    }

    private void btnSelect_Click(object sender, EventArgs e)
    {
        Assistant.instance.SelectModule(dropDownModules.SelectedItem.ToString());
    }
}