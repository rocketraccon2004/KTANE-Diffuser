using KTANE_Diffuser_Winforms.Modules;

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

	private Memory module;

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
		module = new Memory(tbs);
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

    private void btnSolve_Click(object sender, EventArgs e)
    {
		module.setRound(round, txtDisplay.Text, txtNum1.Text, txtNum2.Text, txtNum3.Text, txtNum4.Text);
		module.Solve();
    }   
}
