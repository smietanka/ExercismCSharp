using System;
using System.Linq;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        double sum = 0;
        var list = number.ToString().Select(q => Convert.ToDouble(Convert.ToInt32(q - 48))).ToList();
        foreach (var digit in list)
        {
            var lower = digit;
            var upper = (double)number.ToString().Length;
            sum += Math.Pow(lower, upper);
        }
        return sum == number;
    }
}