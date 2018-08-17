using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        if (multiples.All(q => max < q)) return 0;
        int result = 0;
        Enumerable.Range(multiples.Min(), max - multiples.Min()).ToList().ForEach(q =>
        {
            result += multiples.Any(w => q % w == 0) ? q : 0;
        });
        return result;
    }
}