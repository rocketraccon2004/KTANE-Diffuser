using KTANE_Diffuser_Winforms.Forms;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
namespace KTANE_Diffuser_Winforms;

public class Utils
{
    private static frmAdjacentLetters adjacentLetters;
    private static frmButton button;
    private static frmComplicatedWires complicatedWires;
    private static frmColourFlash colourFlash;
    private static frmEdgeworkInput edgeworkInput;
    private static frmKeypads keypads;
    private static frmKnob knob;
    private static frmMain main;
    private static frmMorseCode morseCode;
    private static frmMaze maze;
    private static frmMemory memory;
    private static frmPassword password;
    private static frmSimon simonSays;
    private static frmWhosOnFirst whosOnFirst;
    private static frmWires wires;
    private static frmWireSequences wireSequences;
    //private static frm3dMaze dMaze;

    public static Form? SelectModuleForm(string Module)
    {
        switch (Module)
        {
            /*case "3d Maze":
                if (dMaze == null)
                {
                    dMaze = new frm3dMaze();
                }
                return dMaze;*/
            case "Adjacent Letters":
                if (adjacentLetters == null)
                {
                    adjacentLetters = new frmAdjacentLetters();
                }
                return adjacentLetters;
            case "Button":
                if (button == null)
                {
                    button = new frmButton();
                }
                return button;
            case "Complicated Wires":
                if (complicatedWires == null)
                {
                    complicatedWires = new frmComplicatedWires();
                }
                return complicatedWires;
            case "Colour Flash":
                if (colourFlash == null)
                {
                    colourFlash = new frmColourFlash();
                }
                return colourFlash;
            case "Edgework Input":
                if (edgeworkInput == null)
                {
                    edgeworkInput = new frmEdgeworkInput();
                }
                return edgeworkInput;
            case "Keypads":
                if (keypads == null)
                {
                    keypads = new frmKeypads();
                }
                return keypads;
            case "Knob":
                if (knob == null)
                {
                    knob = new frmKnob();
                }
                return knob;
            case "Maze":
                if (maze == null)
                {
                    maze = new frmMaze();
                }
                return maze;
            case "Memory":
                if (memory == null)
                {
                    memory = new frmMemory();
                }
                return memory;
            case "Morse Code":
                if (morseCode == null)
                {
                    morseCode = new frmMorseCode();
                }
                return morseCode;
            case "Password":
                if (password == null)
                {
                    password = new frmPassword();
                }
                return password;
            case "Simon Says":
                if (simonSays == null)
                {
                    simonSays = new frmSimon();
                }
                return simonSays;
            case "Wires":
                if (wires == null)
                {
                    wires = new frmWires();
                }
                return wires;
            case "Wire Sequences":
                if (wireSequences == null)
                {
                    wireSequences = new frmWireSequences();
                }
                return wireSequences;
            case "Who's On First":
                if (whosOnFirst == null)
                {
                    whosOnFirst = new frmWhosOnFirst();
                }
                return whosOnFirst;
        }
        return null;
    }


    public static Form getMainForm()
    {
        if (main == null)
        {
            main = new frmMain();
        }
        return main;
    }

    public static bool isOdd(int num)
    {
        return num % 2 != 0;
    }

    public static bool vowel(string toTest)
    {
        return toTest.Contains('A') | toTest.Contains('E') | toTest.Contains('I') | toTest.Contains('O') | toTest.Contains('U');
    }

    public static void throwError(string error)
    {
        MessageBox.Show(error, "Error - KTANE Diffuser", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}