namespace KTANE_Diffuser_Winforms.Forms;
public partial class frmWireSequences : ModuleForm
{
    private int _redWires;
    private int _blueWires;
    private int _blackWires;

    private static Dictionary<int, string[]> redOccurences = new Dictionary<int, string[]>
        {
            { 1, new[] {"C"}},
            { 2, new[] {"B"}},
            { 3, new[] {"A"}},
            { 4, new[] {"A", "C"}},
            { 5, new[] {"B"}},
            { 6, new[] {"A", "C"}},
            { 7, new[] {"A", "B", "C"}},
            { 8, new[] {"A", "B"}},
            { 9, new[] {"B"}},
        };

    private static Dictionary<int, string[]> blueOccurences = new Dictionary<int, string[]>
        {
            { 1, new[] {"B"}},
            { 2, new[] {"A", "C"}},
            { 3, new[] {"B"}},
            { 4, new[] {"A"}},
            { 5, new[] {"B"}},
            { 6, new[] {"B", "C"}},
            { 7, new[] {"C"}},
            { 8, new[] {"A", "C"}},
            { 9, new[] {"A"}},
        };

    private static Dictionary<int, string[]> blackOccurences = new Dictionary<int, string[]>
        {
            { 1, new[] {"A", "B", "C"}},
            { 2, new[] {"A", "C"}},
            { 3, new[] {"B"}},
            { 4, new[] {"A", "C"}},
            { 5, new[] {"B"}},
            { 6, new[] {"B", "C"}},
            { 7, new[] {"A", "B"}},
            { 8, new[] {"C"}},
            { 9, new[] {"C"}},
        };

    public frmWireSequences()
    {
        InitializeComponent();
        _redWires = 0;
        _blueWires = 0;
        _blackWires = 0;
    }

    private string? _color;
    private string? _letter;

    private string Solve(string Colour, string Letter)
    {
        Dictionary<int, string[]> targetDictionary = new Dictionary<int, string[]>();
        int targetWireCount = 0;

        switch (Colour)
        {
            case "Red":
                _redWires++;
                targetWireCount = _redWires;
                targetDictionary = redOccurences;
                break;
            case "Blue":
                _blueWires++;
                targetWireCount = _blueWires;
                targetDictionary = blueOccurences;
                break;
            case "Black":
                _blackWires++;
                targetWireCount = _blackWires;
                targetDictionary = blackOccurences;
                break;
        }

        return $"{(targetDictionary[targetWireCount].Contains(Letter) ? "Cut" : "Don't Cut")}";
    }

    private void btnSolve_Click(object sender, EventArgs e)
    {
        string colour1 = cbWire1Colour.Text;
        string colour2 = cbWire2Colour.Text;
        string colour3 = cbWire3Colour.Text;

        string letter1 = cbWire1End.Text;
        string letter2 = cbWire2End.Text;
        string letter3 = cbWire3End.Text;

        if (colour2 == string.Empty | letter2 == string.Empty)
        {
            MessageBox.Show(Solve(colour1, letter1));
        }
        else if (colour3 == string.Empty | letter3 == string.Empty)
        {
            MessageBox.Show($"{Solve(colour1, letter1)}; {Solve(colour2, letter2)}");
        }
        else
        {
            MessageBox.Show($"{Solve(colour1, letter1)}; {Solve(colour2, letter2)}; {Solve(colour3, letter3)}");
        }
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

    private void btnBack_Click(object sender, EventArgs e)
    {
        Program.switchForm(Utils.getMainForm());
    }
}