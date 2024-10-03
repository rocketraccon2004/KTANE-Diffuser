#pragma warning disable CS8601 // Possible null reference assignment.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
namespace KTANE_Diffuser_Winforms;

public class Bomb
{
    public int batteries;
    public int holders;
    public string serial;
    public Day day;
    public int emptyPlates;
    public Plate[] plates;
    public List<Indicator> indicators;

    public Bomb(int batteries, int holders, string serial, Day day, int emptyPlates, Plate[]? plates, List<Indicator> indicators)
    {
        this.batteries = batteries;
        this.holders = holders;
        this.serial = serial.ToUpper();
        this.day = day;
        this.emptyPlates = emptyPlates;
        this.plates = plates;
        this.indicators = indicators;
    }

    public List<Indicator> getLitIndicators()
    {
        List<Indicator> toReturn = new List<Indicator>();
        foreach (Indicator i in indicators)
        {
            if (i.lit && i.visible)
            {
                toReturn.Add(i);
            }
        }
        return toReturn;
    }


    public List<Indicator> getUnlitIndicators()
    {
        List<Indicator> toReturn = new List<Indicator>();
        foreach (Indicator i in indicators)
        {
            if (!i.lit && i.visible)
            {
                toReturn.Add(i);
            }
        }
        return toReturn;
    }

	public int getLastDigitOfSerial()
	{
		return (int)char.GetNumericValue(Assistant.instance.bomb.serial[5]);
	}

	public int? getFirstDigitOfSerial()
	{
		foreach (char c in Assistant.instance.bomb.serial)
		{
			if (char.IsDigit(c))
			{
				return (int)char.GetNumericValue(c);
			}
		}
		return null;
	}

	public bool hasParallel()
	{
		foreach (Plate p in Assistant.instance.bomb.plates)
		{
			if (p.parallel)
			{
				return true;
			}
		}
		return false;
	}

	public bool hasDVID()
	{
		foreach (Plate p in Assistant.instance.bomb.plates)
		{
			if (p.dvid)
			{
				return true;
			}
		}
		return false;
	}

	public bool hasPS2()
	{
		foreach (Plate p in Assistant.instance.bomb.plates)
		{
			if (p.ps2)
			{
				return true;
			}
		}
		return false;
	}

	public bool hasRJ45()
	{
		foreach (Plate p in Assistant.instance.bomb.plates)
		{
			if (p.rj45)
			{
				return true;
			}
		}
		return false;
	}

	public bool hasSerial()
	{
		foreach (Plate p in Assistant.instance.bomb.plates)
		{
			if (p.serial)
			{
				return true;
			}
		}
		return false;
	}

	public bool hasRCA()
	{
		foreach (Plate p in Assistant.instance.bomb.plates)
		{
			if (p.rca)
			{
				return true;
			}
		}
		return false;
	}

	public bool hasVowelInSerial()
	{
		return Assistant.instance.bomb.serial.Contains('A') | Assistant.instance.bomb.serial.Contains('E') | Assistant.instance.bomb.serial.Contains('I') | Assistant.instance.bomb.serial.Contains('O') | Assistant.instance.bomb.serial.Contains('U');
	}

	public bool hasIndicator(IndicatorType type, bool lit) 
	{
		foreach (Indicator i in indicators)
		{
			if (i.name == type && i.lit == lit)
			{
				return true;
			}
		}
		return false;
	}

	public bool hasDuplicatePorts()
	{
		int DVID = 0;
		int Parallel = 0;
		int PS2 = 0;
		int RJ45 = 0;
		int Serial = 0;
		int RCA = 0;

		foreach (Plate plate in Assistant.instance.bomb.plates)
		{
			if (plate.dvid)
			{
				DVID++;
			}

			if (plate.parallel)
			{
				Parallel++;
			}

			if (plate.ps2)
			{
				PS2++;
			}

			if (plate.rj45)
			{
				RJ45++;
			}

			if (plate.serial)
			{
				Serial++;
			}

			if (plate.rca)
			{
				RCA++;
			}
		}

		return RCA >= 2 || Serial >= 2 || RJ45 >= 2 || Parallel >= 2 || PS2 >= 2 || DVID >= 2;
	}

	public int countLitIndicators()
	{
		int toReturn = 0;

		foreach (Indicator i in Assistant.instance.bomb.indicators)
		{
			if (i.lit && i.visible)
			{
				toReturn++;
			}
		}

		return toReturn;
	}

	public int countUnlitIndicators()
	{
		int toReturn = 0;

		foreach (Indicator i in Assistant.instance.bomb.indicators)
		{
			if (!i.lit && i.visible)
			{
				toReturn++;
			}
		}

		return toReturn;
	}
}

public enum Day
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}
#pragma warning restore CS8618 
#pragma warning restore CS8601 