namespace KTANE_Diffuser_Winforms.Forms;

public partial class frmWires : Form
{
    private string[] wires;

    public frmWires()
    {
        InitializeComponent();
    }

    private void frmWires_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }

    private void btnSolve_Click(object sender, EventArgs e)
    {
        wires = new string[]
        {
            comboBox1.Text,
            comboBox2.Text,
            comboBox3.Text,
            comboBox4.Text,
            comboBox5.Text,
            comboBox6.Text
        };

        if (wires[3] == string.Empty)
        {
            MessageBox.Show(solve(3));
        }
        else if (wires[4] == string.Empty)
        {
            MessageBox.Show(solve(4));
        }
        else if (wires[5] == string.Empty)
        {
            MessageBox.Show(solve(5));
        }
        else
        {
            MessageBox.Show(solve(6));
        }


    }

    public string solve(int noWires)
    {
        switch (noWires)
        {
            //If there are 3 wires
            case 3:
                if (wires[0] != "Red" & wires[1] != "Red" & wires[2] != "Red" & wires[3] != "Red" & wires[4] != "Red" & wires[5] != "Red")
                {
                    return "Cut the second wire";
                }
                else if (wires[2] == "white")
                {
                    return "Cut the last wire";
                }
                else if (blueWires() > 1)
                {
                    return "Cut the last blue wire";
                }
                else
                {
                    return "Cut the last wire";
                }

            //If there are 4 wires
            case 4:
                if (redWires() > 1 & Utils.isOdd(Assistant.instance.lastDigitOfSerial()))
                {
                    return "Cut the last red wire";
                }
                else if (wires[3] == "Yellow" & redWires() == 0)
                {
                    return "Cut the first wire";
                }
                else if (blueWires() > 1)
                {
                    return "Cut the first wire";
                }
                else if (yellowWires() > 1)
                {
                    return "Cut the last wire";
                }
                else
                {
                    return "Cut the second wire";
                }

            //If there are 5 wires
            case 5:
                if (wires[4] == "Black" & Utils.isOdd(Assistant.instance.lastDigitOfSerial()))
                {
                    return "Cut the fourth wire";
                }
                else if (redWires() == 1 & yellowWires() > 1)
                {
                    return "Cut the first wire";
                }
                else if (blackWires() == 0)
                {
                    return "Cut the second wire";
                }
                else
                {
                    return "Cut the first wire";
                }

            //If there are 6 wires
            case 6:
                if (yellowWires() == 0 & Utils.isOdd(Assistant.instance.lastDigitOfSerial()))
                {
                    return "Cut the third wire";
                }
                else if (yellowWires() == 1 & whiteWires() > 1)
                {
                    return "Cut the fourth wire";
                }
                else if (redWires() == 0)
                {
                    return "Cut the last wire";
                }
                else
                {
                    return "Cut the fouth wire";
                }
        }

        return "You shouldn't be seeing this";
    }

    private int blueWires()
    {
        int count = 0;
        foreach (var wire in wires)
        {
            if (wire == "Blue")
            {
                count++;
            }
        }

        return count;
    }

    private int whiteWires()
    {
        int count = 0;
        foreach (var wire in wires)
        {
            if (wire == "White")
            {
                count++;
            }
        }

        return count;
    }

    private int blackWires()
    {
        int count = 0;
        foreach (var wire in wires)
        {
            if (wire == "Black")
            {
                count++;
            }
        }

        return count;
    }

    private int redWires()
    {
        int count = 0;
        foreach (var wire in wires)
        {
            if (wire == "Red")
            {
                count++;
            }
        }

        return count;
    }

    private int yellowWires()
    {
        int count = 0;
        foreach (var wire in wires)
        {
            if (wire == "Yellow")
            {
                count++;
            }
        }

        return count;
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

    private void button2_Click(object sender, EventArgs e)
    {
        Program.switchForm(new frmMain());
    }
}