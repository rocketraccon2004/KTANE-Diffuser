namespace KTANE_Diffuser_Winforms.Forms;

public partial class frmWhosOnFirst : ModuleForm
{
    private Dictionary<string, string> solutions = new Dictionary<string, string>();
    public frmWhosOnFirst()
    {
        InitializeComponent();
        btnSolve.Visible = false;
    }

    private void btnSubmit1_Click(object sender, EventArgs e)
    {
        lblPosition.Text = getPosition(txtWord1.Text.ToUpper());
    }

    private string getPosition(string word)
    {
        switch (word)
        {
            case "BLANK":
                return "Middle Right:";
            case "C":
                return "Top Right:";
            case "CEE":
                return "Bottom Right:";
            case "DISPLAY":
                return "Bottom Right:";
            case "FIRST":
                return "Top Right:";
            case "HOLD ON":
                return "Bottom Right:";
            case "LEAD":
                return "Bottom Right:";
            case "LED":
                return "Middle Left:";
            case "LEED":
                return "Bottom Left:";
            case "NO":
                return "Bottom Right:";
            case "NOTHING":
                return "Middle Left:";
            case "OKAY":
                return "Top Right:";
            case "READ":
                return "Middle Right:";
            case "RED":
                return "Middle Right:";
            case "REED":
                return "Bottom Left:";
            case "SAYS":
                return "Bottom Right:";
            case "SEE":
                return "Bottom Right:";
            case "THEIR":
                return "Middle Right:";
            case "THERE":
                return "Bottom Right:";
            case "THEY ARE":
                return "Middle Left:";
            case "THEY'RE":
                return "Bottom Left:";
            case "UR":
                return "Top Left:";
            case "YES":
                return "Middle Left:";
            case "YOU":
                return "Middle Right:";
            case "YOU ARE":
                return "Bottom Right:";
            case "YOU'RE":
                return "Middle Right:";
            case "YOUR":
                return "Middle Right:";
            case "":
                return "Bottom Left:";
            default:
                return "Not a word";
        }
    }

    private void frmWhosOnFirst_Load(object sender, EventArgs e)
    {
        string[] solutionsArray = File.ReadAllLines("Files/Who's on first.txt");
        foreach (var s in solutionsArray)
        {
            var solution = s.Split(':');
            solutions.Add(solution[0], solution[1]);
        }
        Console.Write("Test");
    }

    private void btnSubmit2_Click(object sender, EventArgs e)
    {
        txtSolution.Text = solutions[txtWord2.Text.ToUpper()];
    }
}
