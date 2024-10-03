using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTANE_Diffuser_Winforms.Modules
{
	public class AdjacentLetters : Module
	{
		public List<TextBox> txts;

		Dictionary<string, string> aboveBelowSolutions = new Dictionary<string, string>()
		{
			{ "A",  "HKPRW" },
			{ "B",  "CDFYZ" },
			{ "C",  "DEMTU" },
			{ "D",  "CJTUW" },
			{ "E",  "KSUWZ" },
			{ "F",  "AGJPQ" },
			{ "G",  "HOQYZ" },
			{ "H",  "DKPMS" },
			{ "I",  "EFNUV" },
			{ "J",  "EHIOS" },
			{ "K",  "DIORZ" },
			{ "L",  "ABRVX" },
			{ "M",  "BFPWX" },
			{ "N",  "AFGHL" },
			{ "O",  "IQSTX" },
			{ "P",  "CFHKR" },
			{ "Q",  "BDIKN" },
			{ "R",  "BNOXY" },
			{ "S",  "GMVYZ" },
			{ "T",  "CJLSU" },
			{ "U",  "BILNY" },
			{ "V",  "AEJQX" },
			{ "W",  "GLQRT" },
			{ "X",  "AJNOV" },
			{ "Y",  "EGMTW" },
			{ "Z",  "CLMPV" }
		};

		Dictionary<string, string> leftRightSolutions = new Dictionary<string, string>()
		{
			{ "A", "GJMOY" },
			{ "B", "IKLRT" },
			{ "C", "BHIJW" },
			{ "D", "IKOPQ" },
			{ "E", "ACGIJ" },
			{ "F", "CERVY" },
			{ "G", "ACFNS" },
			{ "H", "LRTUX" },
			{ "I", "DLOWZ" },
			{ "J", "BQTUW" },
			{ "K", "AFPXY" },
			{ "L", "GKPTZ" },
			{ "M", "EILQT" },
			{ "N", "PQRSV" },
			{ "O", "HJLUZ" },
			{ "P", "DMNOX" },
			{ "Q", "CEOPV" },
			{ "R", "AEGSU" },
			{ "S", "ABEKQ" },
			{ "T", "GVXYZ" },
			{ "U", "FMVXZ" },
			{ "V", "DHMNW" },
			{ "W", "DFHMN" },
			{ "X", "BDFKW" },
			{ "Y", "BCHSU" },
			{ "Z", "JNRSY" }
		};

		string[,] letters;

		public override void Solve()
		{
			List<string> toPress = new List<string>();
			List<char> lettersList = new List<char>();

			foreach (TextBox txt in txts)
			{
				if (!char.TryParse(txt.Text, out char c))
				{
					throwError($"Invalid Input: {txt.Text}");
				}

				if (!char.IsUpper(c))
				{
					if (char.IsLower(c))
					{
						c = char.ToUpper(c);
					}
					else
					{
						throwError($"Not a letter: {c}");
					}
				}

				lettersList.Add(c);
			}

			int index = 0;
			letters = new string[3, 4];

			for (int row = 0; row < 3; row++)
			{
				for (int column = 0; column < 4; column++)
				{
					letters[row, column] = lettersList[index].ToString();
					index++;
				}
			}

			for (int row = 0; row < 3; row++)
			{
				for (int column = 0; column < 4; column++)
				{
					string current = getLetter(row, column);
					string left = getLetter(row, column - 1);
					string right = getLetter(row, column + 1);
					string above = getLetter(row - 1, column);
					string below = getLetter(row + 1, column);

					string solutionAboveBelow = aboveBelowSolutions[current];
					string solutionLeftRight = leftRightSolutions[current];

					if ((solutionAboveBelow.Contains(above) && above != string.Empty) ||
						(solutionAboveBelow.Contains(below) && below != string.Empty) ||
						(solutionLeftRight.Contains(left) && left != string.Empty) ||
						(solutionLeftRight.Contains(right) && right != string.Empty))
					{
						toPress.Add(current);
					}
				}
			}

			MessageBox.Show($@"Press: {string.Join(",", toPress)}");
		}

		private string getLetter(int row, int column)
		{
			try
			{
				return letters[row, column];
			}
			catch (IndexOutOfRangeException)
			{
				return string.Empty;
			}
		}

		public void reset()
		{
			foreach (TextBox txt in txts)
			{
				txt.Text = string.Empty;
			}
		}
	}
}
