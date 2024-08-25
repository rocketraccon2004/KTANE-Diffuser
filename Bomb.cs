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