namespace KTANE_Diffuser_Winforms.Forms;

public partial class frmSimon : Form
{
    public frmSimon()
    {
        InitializeComponent();
    }

    private void backButton_Click(object sender, EventArgs e)
    {
        Program.switchForm(new frmMain());
    }

    private void solveRound1(object sender, EventArgs e)
    {
        lblRound1.Text = solve(txtRound1.Text);
    }

    private void solveRound2(object sender, EventArgs e)
    {
        lblRound2.Text = solve(txtRound2.Text);
    }

    private void solveRound3(object sender, EventArgs e)
    {
        lblRound3.Text = solve(txtRound3.Text);
    }

    private void solveRound4(object sender, EventArgs e)
    {
        lblRound4.Text = solve(txtRound4.Text);
    }

    private void solveRound5(object sender, EventArgs e)
    {
        lblRound5.Text = solve(txtRound5.Text);
    }

    private string solve(string colour)
    {
        if (Assistant.instance.vowelInSerial())
        {
            return withVowel(colour);
        }
        return withoutVowel(colour);
    }

    private string withoutVowel(string colour)
    {
        switch (Assistant.instance.strikes)
        {
            case 0:
                return noVowelZero(colour);
            case 1:
                return noVowelOne(colour);
            default:
                return noVowelTwo(colour);
        }
    }

    private string withVowel(string colour)
    {
        switch (Assistant.instance.strikes)
        {
            case 0:
                return vowelZero(colour);
            case 1:
                return vowelOne(colour);
            default:
                return vowelTwo(colour);
        }
    }

    private string vowelZero(string colour)
    {
        switch (colour)
        {
            case "R":
                return "Blue";
            case "B":
                return "Red";
            case "G":
                return "Yellow";
            case "Y":
                return "Green";
            default:
                return "Invalid";
        }
    }

    private string vowelOne(string colour)
    {
        switch (colour)
        {
            case "R":
                return "Yellow";
            case "B":
                return "Green";
            case "G":
                return "Blue";
            case "Y":
                return "Red";
            default:
                return "Invalid";
        }
    }

    private string vowelTwo(string colour)
    {
        switch (colour)
        {
            case "R":
                return "Green";
            case "B":
                return "Red";
            case "G":
                return "Yellow";
            case "Y":
                return "Blue";
            default:
                return "Invalid";
        }
    }

    private string noVowelZero(string colour)
    {
        switch (colour)
        {
            case "R":
                return "Blue";
            case "B":
                return "Yellow";
            case "G":
                return "Green";
            case "Y":
                return "Red";
            default:
                return "Invalid";
        }
    }

    private string noVowelOne(string colour)
    {
        switch (colour)
        {
            case "B":
                return "Blue";
            case "R":
                return "Red";
            case "G":
                return "Yellow";
            case "Y":
                return "Green";
            default:
                return "Invalid";
        }
    }

    private string noVowelTwo(string colour)
    {
        switch (colour)
        {
            case "R":
                return "Yellow";
            case "B":
                return "Green";
            case "G":
                return "Blue";
            case "Y":
                return "Red";
            default:
                return "Invalid";
        }
    }

    private void strikeButton_Click(object sender, EventArgs e)
    {
        if (ModifierKeys.HasFlag(Keys.Shift))
        {
            Assistant.instance.strikes--;
            return;
        }
        Assistant.instance.strikes++;
    }

    private void frmSimon_FormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }
}
