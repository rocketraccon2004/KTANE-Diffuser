using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTANE_Diffuser_Winforms.Modules
{
	public class ComplicatedWires : Module
	{
		private readonly string cut = "Cut";
		private readonly string dont = "Don't Cut";

		private bool redWire; 
		private bool blueWire; 
		private bool LED; 
		private bool Star;

		public ComplicatedWires(bool redWire, bool blueWire, bool lED, bool star)
		{
			this.redWire = redWire;
			this.blueWire = blueWire;
			LED = lED;
			Star = star;
		}

		public override void Solve()
		{
			MessageBox.Show(cutWire());
		}

		private string cutWire()
		{
			if (redWire & blueWire & LED & Star)
			{
				return dont;
			}
			else if (redWire & blueWire & LED & !Star)
			{
				if (!isOdd(bomb.getLastDigitOfSerial()))
				{
					return cut;
				}
				return dont;
			}
			else if (redWire & blueWire & !LED & Star)
			{
				if (bomb.hasParallel())
				{
					return cut;
				}
				return dont;
			}
			else if (redWire & blueWire & !LED & !Star)
			{
				if (!isOdd(bomb.getLastDigitOfSerial()))
				{
					return cut;
				}
				return dont;
			}
			else if (redWire & !blueWire & LED)
			{
				if (Assistant.instance.bomb.batteries >= 2)
				{
					return cut;
				}
				return dont;
			}
			else if (redWire & !blueWire & !LED & Star)
			{
				return cut;
			}
			else if (redWire & !blueWire & !LED & !Star)
			{
				if (!isOdd(bomb.getLastDigitOfSerial()))
				{
					return cut;
				}
				return dont;
			}
			else if (!redWire & blueWire & LED)
			{
				if (bomb.hasParallel())
				{
					return cut;
				}
				return dont;
			}
			else if (!redWire & blueWire & !LED & Star)
			{
				return dont;
			}
			else if (!redWire & !blueWire & LED & Star)
			{
				if (Assistant.instance.bomb.batteries >= 2)
				{
					return cut;
				}
				return dont;
			}
			else if (!redWire & !blueWire & LED & !Star)
			{
				return dont;
			}
			else if (!redWire & !blueWire & !LED)
			{
				return cut;
			}
			return "Error";
		}
	}
}
