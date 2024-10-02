namespace KTANE_Diffuser_Winforms.Forms;

public partial class frmMemory : ModuleForm
{
    private int round = 1;
    private string round1Answer;
    private string round2Answer;
    private string round3Answer;
    private string round4Answer;
    private int round1Position;
    private int round2Position;
    private int round3Position;
    private int round4Position;

    private List<TextBox> tbs;

    public frmMemory()
    {
        InitializeComponent();
    }

    private void frmMemory_Load(object sender, EventArgs e)
    {
        updateLabel();
        tbs = [
            txtNum1,
            txtNum2,
            txtNum3,
            txtNum4
        ];
    }

    private void updateLabel()
    {
        lblRound.Text = $"Round {round} of 5";
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        if (round == 1)
        {
            Program.switchForm(Utils.getMainForm());
            return;
        }
        round--;
        updateLabel();
    }

    private void button1_Click(object sender, EventArgs e)
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
        MessageBox.Show($"Click {Solve()}");
        if (round == 5)
        {
            Program.switchForm(Utils.getMainForm());
            return;
        }
        round++;
        updateLabel();
    }

    private string Solve()
    {
        switch (round)
        {
            case 1:
                switch (txtDisplay.Text)
                {
                    case "1":
                    case "2":
                        round1Answer = txtNum2.Text;
                        round1Position = 2;
                        return round1Answer;
                    case "3":
                        round1Answer = txtNum3.Text;
                        round1Position = 3;
                        return round1Answer;
                    case "4":
                        round1Answer = txtNum4.Text;
                        round1Position = 4;
                        return round1Answer;
                }
                break;
            case 2:
                switch (txtDisplay.Text)
                {
                    case "1":
                        round2Answer = "4";
                        round2Position = getPosition("4");
                        return round2Answer;
                    case "2":
                        round2Answer = tbs[round1Position - 1].Text;
                        round2Position = round1Position;
                        return round2Answer;
                    case "3":
                        round2Answer = txtNum1.Text;
                        round2Position = 1;
                        return round2Answer;
                    case "4":
                        round2Answer = tbs[round1Position - 1].Text;
                        round2Position = round1Position;
                        return round2Answer;
                }
                break;
            case 3:
                switch (txtDisplay.Text)
                {
                    case "1":
                        round3Answer = round2Answer;
                        round3Position = getPosition(round2Answer);
                        return round3Answer;
                    case "2":
                        round3Answer = round1Answer;
                        round3Position = getPosition(round1Answer);
                        return round3Answer;
                    case "3":
                        round3Answer = txtNum3.Text;
                        round3Position = 3;
                        return round3Answer;
                    case "4":
                        round3Answer = "4";
                        round3Position = getPosition("4");
                        return round3Answer;
                }
                break;
            case 4:
                switch (txtDisplay.Text)
                {
                    case "1":
                        round4Answer = tbs[round1Position - 1].Text;
                        round4Position = round1Position;
                        return round4Answer;
                    case "2":
                        round4Answer = txtNum1.Text;
                        round4Position = 1;
                        return round4Answer;
                    case "3":
                    case "4":
                        round4Answer = tbs[round2Position - 1].Text;
                        round4Position = round2Position;
                        return round4Answer;
                }
                break;
            case 5:
                switch (txtDisplay.Text)
                {
                    case "1":
                        return round1Answer;
                    case "2":
                        return round2Answer;
                    case "3":
                        return round4Answer;
                    case "4":
                        return round3Answer;
                }
                break;
        }
        return "Error";
    }

    private int getPosition(string pos)
    {
        foreach (TextBox tb in tbs)
        {
            if (tb.Text == pos)
            {
                return tbs.IndexOf(tb);
            }
        }
        return 0;
    }
}
