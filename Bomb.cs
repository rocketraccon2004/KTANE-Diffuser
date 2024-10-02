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