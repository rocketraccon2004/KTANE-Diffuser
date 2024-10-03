using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTANE_Diffuser_Winforms.Modules
{
	public class Knob : Module
	{
		bool[] leds;

		public Knob(bool[] leds)
		{
			this.leds = leds;
		}

		public override void Solve()
		{
			// Define conditions for each direction
			bool up = (!leds[0] && leds[1] && !leds[2] && leds[3] && leds[4] && leds[5] && !leds[6] && leds[7] && leds[8] && !leds[9] && leds[10] && leds[11]) ||
			  (leds[0] && !leds[1] && !leds[2] && leds[3] && leds[4] && leds[5] && !leds[6] && !leds[7] && leds[8] && leds[9] && !leds[10] && leds[11]);

			bool down = (!leds[0] && leds[1] && leds[2] && leds[3] && leds[4] && leds[5] && !leds[6] && leds[7] && !leds[8] && !leds[9] && leds[10] && leds[11]) ||
			  (leds[0] && !leds[1] && !leds[2] && leds[3] && leds[4] && !leds[5] && !leds[6] && !leds[7] && leds[8] && !leds[9] && !leds[10] && leds[11]);

			bool left = (!leds[0] && leds[1] && !leds[2] && !leds[3] && !leds[4] && !leds[5] && !leds[6] && leds[7] && leds[8] && leds[9] && !leds[10] && leds[11]) ||
			  (!leds[0] && !leds[1] && !leds[2] && !leds[3] && !leds[4] && !leds[5] && !leds[6] && leds[7] && leds[8] && leds[9] && !leds[10] && !leds[11]);

			bool right = (leds[0] && leds[1] && !leds[2] && leds[3] && leds[4] && leds[5] && leds[6] && !leds[7] && leds[8] && leds[9] && leds[10] && !leds[11]) ||
			  (leds[0] && leds[1] && !leds[2] && leds[3] && leds[4] && leds[5] && leds[6] && !leds[7] && !leds[8] && leds[9] && !leds[10] && !leds[11]);

			if (up)
			{
				MessageBox.Show("Up");
			}

			if (down)
			{
				MessageBox.Show("Down");
			}

			if (left)
			{
				MessageBox.Show("Left");
			}

			if (right)
			{
				MessageBox.Show("Right");
			}

			Program.switchForm(Utils.getMainForm());
		}
	}
}
