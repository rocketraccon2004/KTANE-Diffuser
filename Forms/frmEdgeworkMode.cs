using Newtonsoft.Json;

namespace KTANE_Diffuser_Winforms.Forms;

#pragma warning disable CS8604 // Possible null reference argument.
public partial class frmEdgeworkMode : ModuleForm
{
    public frmEdgeworkMode()
    {
        InitializeComponent();
    }


    private void automaticButton_Click(object sender, EventArgs e)
    {
        StreamReader sr = new StreamReader("Edgework.json");
        string json = string.Empty;
        for (int line = 1; line <= File.ReadAllLines("Edgework.json").Length; line++)
        {
            json += sr.ReadLine();
        }
        Assistant.instance.bomb = JsonConvert.DeserializeObject<Bomb>(json);
        sr.Close();
        Program.switchForm(Utils.getMainForm());
    }

    private void manualButton_Click(object sender, EventArgs e)
    {
        Program.switchForm(Utils.SelectModuleForm("Edgework Input"));
    }

    private void frmEdgeworkSelection_Load(object sender, EventArgs e)
    {
        Assistant.init();
    }
}