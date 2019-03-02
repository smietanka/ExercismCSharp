using System;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if(number < 1) throw new ArgumentOutOfRangeException();
        if (SumOfDivisors(number) == number) return Classification.Perfect;
        if (SumOfDivisors(number) < number) return Classification.Deficient;
        return Classification.Abundant;
    }
    private static int SumOfDivisors(int number)
    {
        var sum = 0;
        for (var i = 1; i < number; i++)
        {
            if (number % i == 0) sum += i;
        }
        return sum;
    }
}
