using KTANE_Diffuser_Winforms.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTANE_Diffuser_Winforms.Forms
{
    public partial class frmPassword : ModuleForm
    {
        public frmPassword()
        {
            InitializeComponent();
        }

        private List<string>? _column1;
        private List<string>? _column2;
        private List<string>? _column3;
        private List<string>? _column4;
        private List<string>? _column5;

        private void btnSolve_Click(object sender, EventArgs e)
        {
            _column1 = [
                txtColumn1Row1.Text,
                txtColumn1Row2.Text,
                txtColumn1Row3.Text,
                txtColumn1Row4.Text,
                txtColumn1Row5.Text,
                txtColumn1Row6.Text,
            ];

            _column2 = [
                txtColumn2Row1.Text,
                txtColumn2Row2.Text,
                txtColumn2Row3.Text,
                txtColumn2Row4.Text,
                txtColumn2Row5.Text,
                txtColumn2Row6.Text,
            ];

            _column3 = [
                txtColumn3Row1.Text,
                txtColumn3Row2.Text,
                txtColumn3Row3.Text,
                txtColumn3Row4.Text,
                txtColumn3Row5.Text,
                txtColumn3Row6.Text,
            ];

            _column4 = [
                txtColumn4Row1.Text,
                txtColumn4Row2.Text,
                txtColumn4Row3.Text,
                txtColumn4Row4.Text,
                txtColumn4Row5.Text,
                txtColumn4Row6.Text,
            ];

            _column5 = [
                txtColumn5Row1.Text,
                txtColumn5Row2.Text,
                txtColumn5Row3.Text,
                txtColumn5Row4.Text,
                txtColumn5Row5.Text,
                txtColumn5Row6.Text,
            ];

			Password module = new Password(_column1, _column2, _column3, _column4, _column5);
			module.Solve();
            Program.switchForm(Utils.getMainForm());
        }
    }
}
