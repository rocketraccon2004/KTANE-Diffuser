using KTANE_Diffuser_Winforms.Modules;

namespace KTANE_Diffuser_Winforms.Forms
{
    public partial class frmColourFlash : ModuleForm
    {
		ColourFlash module;
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

			module = new ColourFlash(words, colours);
			module.Solve();
        }
    }
}