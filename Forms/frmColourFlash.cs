namespace KTANE_Diffuser_Winforms.Forms
{
    public partial class frmColourFlash : ModuleForm
    {
        List<string> words = new List<string>();
        List<string> colours = new List<string>();

        private List<string> possibleWords = [
            "Red",
            "Yellow",
            "Green",
            "Blue",
            "Magenta",
            "White"
        ];
        public frmColourFlash()
        {
            InitializeComponent();
        }

        private void frmColourFlash_Load(object sender, EventArgs e)
        {
            foreach (string s in possibleWords)
            {
                cbWord1.Items.Add(s);
                cbWord2.Items.Add(s);
                cbWord3.Items.Add(s);
                cbWord4.Items.Add(s);
                cbWord5.Items.Add(s);
                cbWord6.Items.Add(s);
                cbWord7.Items.Add(s);
                cbWord8.Items.Add(s);
                cbColour1.Items.Add(s);
                cbColour2.Items.Add(s);
                cbColour3.Items.Add(s);
                cbColour4.Items.Add(s);
                cbColour5.Items.Add(s);
                cbColour6.Items.Add(s);
                cbColour7.Items.Add(s);
                cbColour8.Items.Add(s);
            }
        }

        private void btnStrike_Click(object sender, EventArgs e)
        {
            Assistant.instance.Strike(ModifierKeys.HasFlag(Keys.Shift));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.switchForm(Utils.getMainForm());
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            words.Add(cbWord1.Text);
            words.Add(cbWord2.Text);
            words.Add(cbWord3.Text);
            words.Add(cbWord4.Text);
            words.Add(cbWord5.Text);
            words.Add(cbWord6.Text);
            words.Add(cbWord7.Text);
            words.Add(cbWord8.Text);

            colours.Add(cbColour1.Text);
            colours.Add(cbColour2.Text);
            colours.Add(cbColour3.Text);
            colours.Add(cbColour4.Text);
            colours.Add(cbColour5.Text);
            colours.Add(cbColour6.Text);
            colours.Add(cbColour7.Text);
            colours.Add(cbColour8.Text);

            switch (colours[7])
            {
                case "Red":
                    MessageBox.Show(SolveRed());
                    break;
                case "Yellow":
                    MessageBox.Show(SolveYellow());
                    break;
                case "Green":
                    MessageBox.Show(SolveGreen());
                    break;
                case "Blue":
                    MessageBox.Show(SolveBlue());
                    break;
                case "Magenta":
                    MessageBox.Show(SolveMagenta());
                    break;
                case "White":
                    MessageBox.Show(SolveWhite());
                    break;
            }

            Reset();
            Program.switchForm(Utils.getMainForm());
        }

        private void Reset()
        {
            colours = new List<string>();
            words = new List<string>();
        }

        private string? SolveRed()
        {
            if (CountWord("Green") >= 3)
            {
                return "Press yes on third word green";
            }
            else if (CountColour("Blue") == 1)
            {
                return "Press no when word magenta shown";
            }
            else
            {
                return "Press yes on last white word or colour";
            }
        }

        private string? SolveYellow()
        {
            int magenta = 0;
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i] == "Blue" && colours[i] == "Green")
                {
                    return "Press yes on first green colour";
                }

                else if (words[i] == "White" & (colours[i] == "White" | colours[i] == "Red"))
                {
                    return "Press yes on the second word/colour missmatch";
                }

                else if (words[i] == "Magenta" | colours[i] == "Magenta")
                {
                    magenta++;
                }
            }
            return $"Press no on number {magenta} in sequence";
        }

        private string? SolveGreen()
        {
            string previousWord = string.Empty;
            string previousColour = string.Empty;

            for (int i = 0; i < words.Count; i++)
            {
                if (words[i] == previousWord & colours[i] != previousColour)
                {
                    return "Press no on the fifth entry in the sequence.";
                }
                previousColour = colours[i];
                previousWord = words[i];
            }

            if (CountWord("Magenta") >= 3)
            {
                return "Press no on the first time yellow is used as either the word or the colour";
            }

            return "press Yes on any colour where the colour of the word matches the word itself";
        }

        private string? SolveBlue()
        {
            if (CountMismatches() >= 3)
            {
                return "press Yes on the first time in the sequence where the colour of the word does not match the word itself.";
            }

            for (int i = 0; i < words.Count; i++)
            {
                if (words[i] == "Red" & colours[i] == "Yellow")
                {
                    return "press No when the word White is shown in Red colour";
                }
                else if (words[i] == "Yellow" & colours[i] == "White")
                {
                    return "press No when the word White is shown in Red colour";
                }
            }

            return "press Yes the last time Green is either the word or the colour of the word in the sequence.";
        }

        private string? SolveMagenta()
        {
            string previousColour = string.Empty;
            string previousWord = string.Empty;
            for (int i = 0; i < colours.Count; i++)
            {
                if (colours[i] == previousColour & words[i] != previousWord)
                {
                    return "press Yes on the third entry in the sequence.";
                }
                previousWord = words[i];
                previousColour = colours[i];
            }

            if (CountWord("Yellow") > CountColour("Blue"))
            {
                return "press No the last time the word Yellow is in the sequence.";
            }

            return "press No on the first time in the sequence where the colour of the word matches the word of the seventh entry in the sequence.";
        }

        private string? SolveWhite()
        {
            if (colours[2] == words[3] | colours[2] == words[4])
            {
                return "press No the first time that Blue is used as the word or the colour of the word in the sequence.";
            }

            for (int i = 0; i < words.Count; i++)
            {
                if (words[i] == "Yellow" & colours[i] == "Red")
                {
                    return "press Yes on the last time Blue is used as the colour of the word.";
                }
            }

            return "Press no at any time";
        }

        private int CountWord(string word)
        {
            int count = 0;
            foreach (var s in words)
            {
                if (s == word)
                {
                    count++;
                }
            }
            return count;
        }

        private int CountColour(string colour)
        {
            int count = 0;
            foreach (var s in colours)
            {
                if (s == colour)
                {
                    count++;
                }
            }
            return count;
        }

        private int CountMismatches()
        {
            int count = 0;
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i] != colours[i])
                {
                    count++;
                }
            }
            return count;
        }
    }
}