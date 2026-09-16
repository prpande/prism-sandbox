namespace Sandbox;

public static class Totals
{
    public static int SumAll(int[] values)
    {
        int total = 0;
        foreach (var entry in values)
        {
            total += entry;
        }

        return total;
    }
}
