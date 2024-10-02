namespace KTANE_Diffuser_Winforms.Forms;

public partial class frmComplicatedWires : ModuleForm
{
    private string cut = "Cut";
    private string dont = "Don't Cut";
    public frmComplicatedWires()
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
        MessageBox.Show(solve());
    }

    private string solve()
    {
        bool redWire = cbRedWire.Checked;
        bool blueWire = cbBlueWire.Checked;
        bool LED = cbLED.Checked;
        bool Star = cbStar.Checked;

        if (redWire & blueWire & LED & Star)
        {
            return dont;
        }
        else if (redWire & blueWire & LED & !Star)
        {
            if (!Utils.isOdd(Assistant.instance.lastDigitOfSerial()))
            {
                return cut;
            }
            return dont;
        }
        else if (redWire & blueWire & !LED & Star)
        {
            if (Assistant.instance.parallel())
            {
                return cut;
            }
            return dont;
        }
        else if (redWire & blueWire & !LED & !Star)
        {
            if (!Utils.isOdd(Assistant.instance.lastDigitOfSerial()))
            {
                return cut;
            }
            return dont;
        }
        else if (redWire & !blueWire & LED)
        {
            if (Assistant.instance.bomb.batteries >= 2)
            {
                return cut;
            }
            return dont;
        }
        else if (redWire & !blueWire & !LED & Star)
        {
            return cut;
        }
        else if (redWire & !blueWire & !LED & !Star)
        {
            if (!Utils.isOdd(Assistant.instance.lastDigitOfSerial()))
            {
                return cut;
            }
            return dont;
        }
        else if (!redWire & blueWire & LED)
        {
            if (Assistant.instance.parallel())
            {
                return cut;
            }
            return dont;
        }
        else if (!redWire & blueWire & !LED & Star)
        {
            return dont;
        }
        else if (!redWire & !blueWire & LED & Star)
        {
            if (Assistant.instance.bomb.batteries >= 2)
            {
                return cut;
            }
            return dont;
        }
        else if (!redWire & !blueWire & LED & !Star)
        {
            return dont;
        }
        else if (!redWire & !blueWire & !LED)
        {
            return cut;
        }
        return "Error";
    }
}
