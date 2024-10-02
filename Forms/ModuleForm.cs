namespace KTANE_Diffuser_Winforms.Forms
{
    public partial class ModuleForm : Form
    {
        public ModuleForm()
        {
            InitializeComponent();
        }

        public void CloseProgram(object sender, FormClosingEventArgs e)
        {
            if (Visible)
            {
                string message = "Are you sure you want to quit the program?";
                string caption = "Quit Program";

                DialogResult result = MessageBox.Show(
                    message,
                    caption,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                //if the user clicks no, don't close the program
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Visible = false;
                    Application.Exit();
                }
            }
        }
    }
}
