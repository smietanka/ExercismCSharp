using System;
using System.Linq;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length != secondStrand.Length) throw new ArgumentException();
        return firstStrand.Zip(secondStrand, (currentFirstChar, currentSecondChar) => new { currentFirstChar, currentSecondChar })
            .Count(z => z.currentFirstChar != z.currentSecondChar);
    }
}