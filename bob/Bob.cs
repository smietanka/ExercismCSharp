using System;
using System.Collections.Generic;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();
        
        if (statement.EndsWith('?'))
        {
            if (statement.IsUpperCase()) return "Calm down, I know what I'm doing!";
            return "Sure.";
        }
        else if (statement.IsUpperCase()) return "Whoa, chill out!";

        if (statement.EndsWith('!') && statement.IsUpperCase())
            return "Whoa, chill out!";

        if (statement.IsWhiteSpace()) return "Fine. Be that way!";
        return "Whatever.";
    }

    private static bool IsUpperCase(this string statement) => statement.Any(q => Char.IsLetter(q)) && !statement.Any(q => char.IsLower(q));
    private static bool IsWhiteSpace(this string statement) => !statement.ToArray().Any(Char.IsLetterOrDigit);
}