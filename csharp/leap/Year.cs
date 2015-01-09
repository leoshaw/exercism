public class Year
{
    public static bool IsLeap(int i)
    {
        if (i % 4 != 0)
        {
            return false;
        }

        if (i % 100 == 0)
        {
            if (i % 400 != 0)
            {
                return false;
            }
        }

        return true;
    }
}