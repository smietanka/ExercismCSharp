using System.Collections.Generic;
using System.Linq;

public static class Raindrops
{
    public static string Convert(int number)
    {
        var result = new List<string>();
        if(number % 3 == 0) result.Add("Pling");
        if (number % 5 == 0) result.Add("Plang");
        if (number % 7 == 0) result.Add("Plong");
        return result.Any() ? string.Join("", result) : number.ToString();
    }
}