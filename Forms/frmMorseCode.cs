using System.Diagnostics;
using System.Runtime.InteropServices;

namespace KTANE_Diffuser_Winforms.Forms;

public partial class frmMorseCode : Form
{
    public frmMorseCode()
    {
        InitializeComponent();
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        Program.switchForm(new frmMain());
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

    private static readonly Dictionary<string, float> WordsDict = new Dictionary<string, float>
        {
            { "shell", 3.505f },
            { "halls", 3.515f },
            { "slick", 3.522f },
            { "trick", 3.532f },
            { "boxes", 3.535f },
            { "leaks", 3.542f },
            { "strobe", 3.545f },
            { "bistro", 3.552f },
            { "flick", 3.555f },
            { "bombs", 3.565f },
            { "break", 3.572f },
            { "brick", 3.575f },
            { "steak", 3.582f },
            { "sting", 3.592f },
            { "vector", 3.595f },
            { "beats", 3.600f }
        };

    private void btnSolve_Click(object sender, EventArgs e)
    {
        MessageBox.Show($"Tune to {WordsDict[comboBox1.Text]} MHz");
    }

    private void frmMorseCode_Load(object sender, EventArgs e)
    {
        foreach (string s in WordsDict.Keys)
        {
            comboBox1.Items.Add(s);
        }
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        string url = "https://morsecode.world/international/translator.html";
        linkLabel1.LinkVisited = true;
        try
        {
            Process.Start(url);
        }
        catch
        {
            // hack because of this: https://github.com/dotnet/corefx/issues/10361
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                url = url.Replace("&", "^&");
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
        }
    }

    private void frmMorseCode_FormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }
}
