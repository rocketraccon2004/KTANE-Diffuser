using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTANE_Diffuser_Winforms.Modules
{
	public class Wires : Module
	{
		private string[] wires;

		public Wires(string[] wires)
		{
			this.wires = wires;
		}

		public override void Solve()
		{
			if (wires[3] == string.Empty)
			{
				MessageBox.Show(Solve(3));
				MessageBox.Show(Solve(3));
			}
			else if (wires[4] == string.Empty)
			{
				MessageBox.Show(Solve(4));
			}
			else if (wires[5] == string.Empty)
			{
				MessageBox.Show(Solve(5));
			}
			else
			{
				MessageBox.Show(Solve(6));
			}

			Program.switchForm(Utils.getMainForm());
		}

		private string Solve(int noWires)
		{
			switch (noWires)
			{
				//If there are 3 wires
				case 3:
					if (wires[0] != "Red" & wires[1] != "Red" & wires[2] != "Red" & wires[3] != "Red" & wires[4] != "Red" & wires[5] != "Red")
					{
						return "Cut the second wire";
					}
					else if (wires[2] == "white")
					{
						return "Cut the last wire";
					}
					else if (blueWires() > 1)
					{
						return "Cut the last blue wire";
					}
					else
					{
						return "Cut the last wire";
					}

				//If there are 4 wires
				case 4:
					if (redWires() > 1 & isOdd(bomb.getLastDigitOfSerial()))
					{
						return "Cut the last red wire";
					}
					else if (wires[3] == "Yellow" & redWires() == 0)
					{
						return "Cut the first wire";
					}
					else if (blueWires() > 1)
					{
						return "Cut the first wire";
					}
					else if (yellowWires() > 1)
					{
						return "Cut the last wire";
					}
					else
					{
						return "Cut the second wire";
					}

				//If there are 5 wires
				case 5:
					if (wires[4] == "Black" & isOdd(bomb.getLastDigitOfSerial()))
					{
						return "Cut the fourth wire";
					}
					else if (redWires() == 1 & yellowWires() > 1)
					{
						return "Cut the first wire";
					}
					else if (blackWires() == 0)
					{
						return "Cut the second wire";
					}
					else
					{
						return "Cut the first wire";
					}

				//If there are 6 wires
				case 6:
					if (yellowWires() == 0 & isOdd(bomb.getLastDigitOfSerial()))
					{
						return "Cut the third wire";
					}
					else if (yellowWires() == 1 & whiteWires() > 1)
					{
						return "Cut the fourth wire";
					}
					else if (redWires() == 0)
					{
						return "Cut the last wire";
					}
					else
					{
						return "Cut the fouth wire";
					}
			}

			return "You shouldn't be seeing this";
		}

		private int blueWires()
		{
			int count = 0;
			foreach (var wire in wires)
			{
				if (wire == "Blue")
				{
					count++;
				}
			}

			return count;
		}

		private int whiteWires()
		{
			int count = 0;
			foreach (var wire in wires)
			{
				if (wire == "White")
				{
					count++;
				}
			}

			return count;
		}

		private int blackWires()
		{
			int count = 0;
			foreach (var wire in wires)
			{
				if (wire == "Black")
				{
					count++;
				}
			}

			return count;
		}

		private int redWires()
		{
			int count = 0;
			foreach (var wire in wires)
			{
				if (wire == "Red")
				{
					count++;
				}
			}

			return count;
		}

		private int yellowWires()
		{
			int count = 0;
			foreach (var wire in wires)
			{
				if (wire == "Yellow")
				{
					count++;
				}
			}

			return count;
		}
	}
}
