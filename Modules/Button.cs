using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTANE_Diffuser_Winforms.Modules
{
	public class Button : Module
	{
		string Colour;
		string Label;

		public Button (string Colour, string Label)
		{
			this.Colour = Colour;
			this.Label = Label;
		}

		public override void Solve()
		{
			if (Colour == "Blue" & Label == "Abort")
			{
				holdButton();
			}
			else if (Assistant.instance.bomb.batteries > 1 & Label == "Detonate")
			{
				pressAndReleaseButton();
			}
			else if (Colour == "White" & bomb.hasIndicator(IndicatorType.CAR, true))
			{
				holdButton();
			}
			else if (Colour == "Yellow")
			{
				holdButton();
			}
			else if (Assistant.instance.bomb.batteries > 2 &&
				bomb.hasIndicator(IndicatorType.FRK, true))
			{
				pressAndReleaseButton();
			}
			else if (Colour == "Red" & Label == "Hold")
			{
				pressAndReleaseButton();
			}
			else
			{
				holdButton();
			}
		}

		private void pressAndReleaseButton()
		{
			MessageBox.Show(@"Press and immediately release the button", @"Button answer");
			Program.switchForm(Utils.getMainForm());
		}

		private void holdButton()
		{
			MessageBox.Show(
				@"Hold the button 
Blue Strip: Release when 4 in any position on timer 
Yellow Strip: Release when 5 in any position on timer 
Else: Release when 1 in any position on timer", @"Button answer");
			Program.switchForm(Utils.getMainForm());
		}
	}
}
