using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTANE_Diffuser_Winforms.Modules
{
	public class WireSequences : Module
	{
		private int _redWires;
		private int _blueWires;
		private int _blackWires;
		private string? _color;
		private string? _letter;

		string colour1;
		string colour2;
		string colour3;

		string letter1;
		string letter2;
		string letter3;

		private static Dictionary<int, string[]> redOccurences = new Dictionary<int, string[]>
		{
			{ 1, new[] {"C"}},
			{ 2, new[] {"B"}},
			{ 3, new[] {"A"}},
			{ 4, new[] {"A", "C"}},
			{ 5, new[] {"B"}},
			{ 6, new[] {"A", "C"}},
			{ 7, new[] {"A", "B", "C"}},
			{ 8, new[] {"A", "B"}},
			{ 9, new[] {"B"}},
		};

		private static Dictionary<int, string[]> blueOccurences = new Dictionary<int, string[]>
		{
			{ 1, new[] {"B"}},
			{ 2, new[] {"A", "C"}},
			{ 3, new[] {"B"}},
			{ 4, new[] {"A"}},
			{ 5, new[] {"B"}},
			{ 6, new[] {"B", "C"}},
			{ 7, new[] {"C"}},
			{ 8, new[] {"A", "C"}},
			{ 9, new[] {"A"}},
		};

		private static Dictionary<int, string[]> blackOccurences = new Dictionary<int, string[]>
		{
			{ 1, new[] {"A", "B", "C"}},
			{ 2, new[] {"A", "C"}},
			{ 3, new[] {"B"}},
			{ 4, new[] {"A", "C"}},
			{ 5, new[] {"B"}},
			{ 6, new[] {"B", "C"}},
			{ 7, new[] {"A", "B"}},
			{ 8, new[] {"C"}},
			{ 9, new[] {"C"}},
		};

		public void setWires (string colour1, string colour2, string colour3, string letter1, string letter2, string letter3)
		{
			this.colour1 = colour1;
			this.colour2 = colour2;
			this.colour3 = colour3;
			this.letter1 = letter1;
			this.letter2 = letter2;
			this.letter3 = letter3;
		}

		public override void Solve()
		{
			if (colour2 == string.Empty | letter2 == string.Empty)
			{
				MessageBox.Show(Solve(colour1, letter1));
			}
			else if (colour3 == string.Empty | letter3 == string.Empty)
			{
				MessageBox.Show($"{Solve(colour1, letter1)}; {Solve(colour2, letter2)}");
			}
			else
			{
				MessageBox.Show($"{Solve(colour1, letter1)}; {Solve(colour2, letter2)}; {Solve(colour3, letter3)}");
			}
		}

		
		private string Solve(string Colour, string Letter)
		{
			Dictionary<int, string[]> targetDictionary = new Dictionary<int, string[]>();
			int targetWireCount = 0;

			switch (Colour)
			{
				case "Red":
					_redWires++;
					targetWireCount = _redWires;
					targetDictionary = redOccurences;
					break;
				case "Blue":
					_blueWires++;
					targetWireCount = _blueWires;
					targetDictionary = blueOccurences;
					break;
				case "Black":
					_blackWires++;
					targetWireCount = _blackWires;
					targetDictionary = blackOccurences;
					break;
			}

			return $"{(targetDictionary[targetWireCount].Contains(Letter) ? "Cut" : "Don't Cut")}";
		}
	}
}
