#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace KTANE_Diffuser_Winforms.Forms;

public partial class frmEdgeworkInput : Form
{
    public frmEdgeworkInput()
    {
        InitializeComponent();
    }

    private void frmEdgeworkInput_Load(object sender, EventArgs e)
    {
        foreach (var s in Enum.GetNames(typeof(Day)))
        {
            dayOfWeekComboBox.Items.Add(s);
        }
    }

    private void frmEdgeworkInput_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }

    private void submitButton_Click(object sender, EventArgs e)
    {
        int batteries;
        int holders;
        int plates;
        List<Indicator> indicators;
        Day day = (Day)Enum.Parse(typeof(Day), dayOfWeekComboBox.Text.ToString());
        string serial = serialNumberTextBox.Text;

        if (!int.TryParse(serial[5].ToString(), out _))
        {
            MessageBox.Show("Invalid Parameter: Serial must end in digit");
        }

        if (!int.TryParse(batteryTextBox.Text, out batteries))
        {
            MessageBox.Show($"Invalid Parameter: Batteries ({batteryTextBox.Text})");
        }
        if (!int.TryParse(batteryHolderTextBox.Text, out holders))
        {
            MessageBox.Show($"Invalid Parameter: Holders ({batteryHolderTextBox.Text})");
        }
        if (!int.TryParse(portPlateNumTextBox.Text, out plates))
        {
            MessageBox.Show($"Invalid Parameter: Plates ({portPlateNumTextBox.Text})");
        }

        indicators = new List<Indicator>()
        {
            new Indicator()
            {
                name = "SND",
                lit = sndLitCheckBox.Checked,
                visible = sndVisibleCheckBox.Checked
            },
            new Indicator()
            {
                name = "CLR",
                lit = clrLitCheckBox.Checked,
                visible = clrVisibleCheckBox.Checked
            },
            new Indicator()
            {
                name = "CAR",
                lit = carLitCheckBox.Checked,
                visible = carVisibleCheckBox.Checked
            },
            new Indicator()
            {
                name = "IND",
                lit = indLitCheckBox.Checked,
                visible = indVisibleCheckBox.Checked
            },
            new Indicator()
            {
                name = "FRQ",
                lit = frqLitCheckBox.Checked,
                visible = frqVisibleCheckBox.Checked
            },
            new Indicator()
            {
                name = "SIG",
                lit = sigLitCheckBox.Checked,
                visible = sigVisibleCheckBox.Checked
            },
            new Indicator()
            {
                name = "NSA",
                lit = nsaLitCheckBox.Checked,
                visible = nsaVisibleCheckBox.Checked
            },
            new Indicator()
            {
                name = "MSA",
                lit = msaLitCheckBox.Checked,
                visible = msaVisibleCheckBox.Checked
            },
            new Indicator()
            {
                name = "TRN",
                lit = trnLitCheckBox.Checked,
                visible = trnVisibleCheckBox.Checked
            },
            new Indicator()
            {
                name = "BOB",
                lit = bobLitCheckBox.Checked,
                visible = bobVisibleCheckBox.Checked
            },
            new Indicator()
            {
                name = "FRK",
                lit = frkLitCheckBox.Checked,
                visible = frkVisibleCheckBox.Checked
            },
        };

        if (plates != 0)
        {
            frmPlates p = new frmPlates();
            p.start(batteries, holders, plates, day, indicators, serial);
            return;
        }

        Assistant.instance.bomb = new Bomb(batteries, holders, serial, day, plates, null, indicators);
        Program.switchForm(new frmMain());
    }
}