namespace KTANE_Diffuser_Winforms;

public class Utils
{
    public static bool isOdd(int num)
    {
        return num % 2 != 0;
    }

    public static bool vowel(string toTest)
    {
        return toTest.Contains('A') | toTest.Contains('E') | toTest.Contains('I') | toTest.Contains('O') | toTest.Contains('U');
    }

    public static void throwError(string error)
    {
        MessageBox.Show(error, "Error - KTANE Diffuser", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}