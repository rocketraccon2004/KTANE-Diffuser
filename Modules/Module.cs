using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTANE_Diffuser_Winforms.Modules
{
	public abstract class Module
	{
		public Bomb bomb => Assistant.instance.bomb;

		public bool isOdd(int num)
		{
			return num % 2 != 0;
		}

		public void throwError(string error)
		{
			MessageBox.Show(error, "Error - KTANE Diffuser", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public abstract void Solve();
	}
}
