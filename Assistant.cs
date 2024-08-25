using KTANE_Diffuser_Winforms.Forms;

namespace KTANE_Diffuser_Winforms;

public class Assistant
{
    public static Assistant? instance;

    public Bomb? bomb;

    public int strikes;

    public List<string> modules = new List<string>()
    {
        "Wires",
        "Button",
        "Keypads",
        "Simon Says",
        "Who's On First",
        "Memory",
        "Morse Code",
        "Complicated Wires",
        "Wire Sequences",
        "Maze",
        "Password",
        "Knob",
    };

    public static void init()
    {
        if (instance == null) instance = new Assistant();
    }

    public int lastDigitOfSerial()
    {
        return int.Parse(bomb.serial[5].ToString());
    }

    public void SelectModule(string Module)
    {
        switch (Module)
        {
            case "Button":
                Program.switchForm(new frmButton());
                break;
            case "Wires":
                Program.switchForm(new frmWires());
                break;
            case "Keypads":
                Program.switchForm(new frmKeypads());
                break;
            case "Simon Says":
                Program.switchForm(new frmSimon());
                break;
            case "Who's On First":
                Program.switchForm(new frmWhosOnFirst());
                break;
            case "Memory":
                Program.switchForm(new frmMemory());
                break;
            case "Morse Code":
                Program.switchForm(new frmMorseCode());
                break;
            case "Complicated Wires":
                Program.switchForm(new frmComplicatedWires());
                break;
            case "Wire Sequences":
                Program.switchForm(new frmWireSequences());
                break;
            case "Maze":
                Program.switchForm(new frmMaze());
                break;
            case "Password":
                Program.switchForm(new frmPassword());
                break;
            case "Knob":
                Program.switchForm(new frmKnob());
                break;
        }
    }

    public bool parallel()
    {
        foreach (Plate p in bomb.plates)
        {
            if (p.parallel)
            {
                return true;
            }
        }
        return false;
    }

    public bool DVID()
    {
        foreach (Plate p in bomb.plates)
        {
            if (p.dvid)
            {
                return true;
            }
        }
        return false;
    }

    public bool PS2()
    {
        foreach (Plate p in bomb.plates)
        {
            if (p.ps2)
            {
                return true;
            }
        }
        return false;
    }

    public bool rj45()
    {
        foreach (Plate p in bomb.plates)
        {
            if (p.rj45)
            {
                return true;
            }
        }
        return false;
    }

    public bool serial()
    {
        foreach (Plate p in bomb.plates)
        {
            if (p.serial)
            {
                return true;
            }
        }
        return false;
    }

    public bool rca()
    {
        foreach (Plate p in bomb.plates)
        {
            if (p.rca)
            {
                return true;
            }
        }
        return false;
    }

    public bool vowelInSerial()
    {
        return bomb.serial.Contains('A') | bomb.serial.Contains('E') | bomb.serial.Contains('I') | bomb.serial.Contains('O') | bomb.serial.Contains('U');
    }

    public bool litCAR()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "CAR" & i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }

    public bool unlitCAR()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "CAR" & !i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool litSND()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "SND" & i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool unlitSND()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "SND" & !i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool litCLR()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "CLR" & i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }

    public bool unlitCLR()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "CAR" & !i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool litIND()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "IND" & i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool unlitIND()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "IND" & !i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool litFRQ()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "FRQ" & i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool unlitFRQ()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "FRQ" & !i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool litSIG()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "SIG" & i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool unlitSIG()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "SIG" & !i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool litNSA()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "NSA" & i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool unlitNSA()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "NSA" & !i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool litMSA()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "MSA" & i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool unlitMSA()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "MSA" & !i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool litTRN()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "TRN" & i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool unlitTRN()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "TRN" & !i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool litBOB()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "BOB" & i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool unlitBOB()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "BOB" & !i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool litFRK()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "FRK" & i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool unlitFRK()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "FRK" & !i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
}