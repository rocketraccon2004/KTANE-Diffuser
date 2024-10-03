
namespace KTANE_Diffuser_Winforms;

public class Assistant
{
    public static Assistant instance = null!;

    public Bomb bomb = null!;

    public int strikes;

	public static void init()
	{
		instance = new Assistant();
	}
}