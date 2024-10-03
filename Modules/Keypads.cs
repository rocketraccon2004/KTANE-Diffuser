using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTANE_Diffuser_Winforms.Modules
{
	public class Keypads : Module
	{
		private string image1Name;
		private string image2Name;
		private string image3Name;
		private string image4Name;

		private string[] solution1 =
		[
			"O", "A", "Lambda", "Lightning", "Squid", "H", "Backwards C"
		];

		private string[] solution2 =
		[
			"E", "O", "Backwards C", "Swirl", "White Star", "H", "Question Mark"
		];

		private string[] solution3 =
		[
			"Copyright", "Butt", "Swirl", "X", "Unfinished R", "Lambda", "White Star"
		];

		private string[] solution4 =
		[
			"6", "Paragraph", "B", "Squid", "X", "Question Mark", "Smiley Face"
		];

		private string[] solution5 =
		[
			"Trident", "Smiley Face", "B", "C", "Paragraph", "3", "Black Star"
		];

		private string[] solution6 =
		[
			"6", "E", "Hashtag", "AE", "Trident", "N", "Omega"
		];

		public Keypads(string image1Name, string image2Name, string image3Name, string image4Name)
		{
			this.image1Name = image1Name;
			this.image2Name = image2Name;
			this.image3Name = image3Name;
			this.image4Name = image4Name;
		}

		public override void Solve()
		{
			if (solution1.Contains(image1Name) & solution1.Contains(image2Name) & solution1.Contains(image3Name) & solution1.Contains(image4Name))
			{
				MessageBox.Show(solve(1));
			}
			else if (solution2.Contains(image1Name) & solution2.Contains(image2Name) & solution2.Contains(image3Name) & solution2.Contains(image4Name))
			{
				MessageBox.Show(solve(2));
			}
			else if (solution3.Contains(image1Name) & solution3.Contains(image2Name) & solution3.Contains(image3Name) & solution3.Contains(image4Name))
			{
				MessageBox.Show(solve(3));
			}
			else if (solution4.Contains(image1Name) & solution4.Contains(image2Name) & solution4.Contains(image3Name) & solution4.Contains(image4Name))
			{
				MessageBox.Show(solve(4));
			}
			else if (solution5.Contains(image1Name) & solution5.Contains(image2Name) & solution5.Contains(image3Name) & solution5.Contains(image4Name))
			{
				MessageBox.Show(solve(5));
			}
			else if (solution6.Contains(image1Name) & solution6.Contains(image2Name) & solution6.Contains(image3Name) & solution6.Contains(image4Name))
			{
				MessageBox.Show(solve(6));
			}
			else
			{
				MessageBox.Show("Can't find solution", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			Program.switchForm(Utils.getMainForm());
		}

		private string solve(int solutionNo)
		{
			List<string> solution = new List<string>();

			switch (solutionNo)
			{
				case 1:
					solution = solution1.ToList();
					break;
				case 2:
					solution = solution2.ToList();
					break;
				case 3:
					solution = solution3.ToList();
					break;
				case 4:
					solution = solution4.ToList();
					break;
				case 5:
					solution = solution5.ToList();
					break;
				case 6:
					solution = solution6.ToList();
					break;
			}

			List<int> indexes =
			[
				solution.IndexOf(image1Name),
			solution.IndexOf(image2Name),
			solution.IndexOf(image3Name),
			solution.IndexOf(image4Name),
		];

			indexes.Sort();

			List<string> ordered =
			[
				solution[indexes[0]],
			solution[indexes[1]],
			solution[indexes[2]],
			solution[indexes[3]]
			];

			return $"Order: {ordered[0]}, {ordered[1]}, {ordered[2]}, {ordered[3]}";
		}
	}
}
