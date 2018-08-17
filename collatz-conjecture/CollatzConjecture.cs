using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        int counter = 0;
        if (number < 1) throw new ArgumentException();
        SubStep(number, ref counter);
        return counter;
    }
    private static int SubStep(int number, ref int counter)
    {
        if (number == 1) return 0;
        counter++;
        return SubStep(number % 2 == 0 ? number / 2 : (3 * number) + 1, ref counter);
    }
}