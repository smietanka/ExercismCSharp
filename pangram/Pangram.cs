using System;
using System.Linq;

public static class Pangram
{
    private static readonly string EnglishAlphabet = "abcdefghijklmnopqrstuvwxyz";

    public static bool IsPangram(string input)
    {
        if (string.IsNullOrEmpty(input)) return false;
        input = new string(input.Trim().ToLower().Where(Char.IsLetter).ToArray());
        return EnglishAlphabet.Intersect(input).Count() == EnglishAlphabet.Count();
    }
}
