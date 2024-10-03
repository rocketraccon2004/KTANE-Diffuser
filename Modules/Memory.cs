using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTANE_Diffuser_Winforms.Modules
{
	public class Memory : Module
	{
		private int round;
		private string display;
		private string round1Answer;
		private string round2Answer;
		private string round3Answer;
		private string round4Answer;
		private string n1;
		private string n2;
		private string n3;
		private string n4;
		private int round1Position;
		private int round2Position;
		private int round3Position;
		private int round4Position;
		private List<TextBox> tbs;

		public Memory(List<TextBox> tbs)
		{
			this.tbs = tbs;
		}

		public void setRound(int round, string display, string n1, string n2, string n3, string n4) 
		{
			this.round = round;
			this.display = display;
			this.n1 = n1;
			this.n2 = n2;
			this.n3 = n3;
			this.n4 = n4;
		}

		public override void Solve()
		{
			MessageBox.Show($"Click {Solve(round)}");
			if (round == 5)
			{
				Program.switchForm(Utils.getMainForm());
				return;
			}
			round++;
		}

		private string Solve(int round)
		{
			switch (round)
			{
				case 1:
					switch (display)
					{
						case "1":
						case "2":
							round1Answer = n2;
							round1Position = 2;
							return round1Answer;
						case "3":
							round1Answer = n3;
							round1Position = 3;
							return round1Answer;
						case "4":
							round1Answer = n4;
							round1Position = 4;
							return round1Answer;
					}
					break;
				case 2:
					switch (display)
					{
						case "1":
							round2Answer = "4";
							round2Position = getPosition("4");
							return round2Answer;
						case "2":
							round2Answer = tbs[round1Position - 1].Text;
							round2Position = round1Position;
							return round2Answer;
						case "3":
							round2Answer = n1;
							round2Position = 1;
							return round2Answer;
						case "4":
							round2Answer = tbs[round1Position - 1].Text;
							round2Position = round1Position;
							return round2Answer;
					}
					break;
				case 3:
					switch (display)
					{
						case "1":
							round3Answer = round2Answer;
							round3Position = getPosition(round2Answer);
							return round3Answer;
						case "2":
							round3Answer = round1Answer;
							round3Position = getPosition(round1Answer);
							return round3Answer;
						case "3":
							round3Answer = n3;
							round3Position = 3;
							return round3Answer;
						case "4":
							round3Answer = "4";
							round3Position = getPosition("4");
							return round3Answer;
					}
					break;
				case 4:
					switch (display)
					{
						case "1":
							round4Answer = tbs[round1Position - 1].Text;
							round4Position = round1Position;
							return round4Answer;
						case "2":
							round4Answer = n1;
							round4Position = 1;
							return round4Answer;
						case "3":
						case "4":
							round4Answer = tbs[round2Position - 1].Text;
							round4Position = round2Position;
							return round4Answer;
					}
					break;
				case 5:
					switch (display)
					{
						case "1":
							return round1Answer;
						case "2":
							return round2Answer;
						case "3":
							return round4Answer;
						case "4":
							return round3Answer;
					}
					break;
			}
			return "Error";
		}

		private int getPosition(string pos)
		{
			foreach (TextBox tb in tbs)
			{
				if (tb.Text == pos)
				{
					return tbs.IndexOf(tb);
				}
			}
			return 0;
		}
	}
}
