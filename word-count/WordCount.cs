using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static class WordCount
{
    public static IDictionary<string, int> CountWords(string phrase)
    {
        var editedPhrase = Regex.Replace(phrase.ToLower(), @"\s\'(.*?)\'\s", " $1 ") //replace quotations to without
            .Split(new char[] { ' ', ',', '\n', ':', '.', '!' }, StringSplitOptions.RemoveEmptyEntries) // split by every characters and remove empty strings
            .Where(q => q.ToArray().Any(Char.IsLetterOrDigit)); // get only this where strings is letter or digits

        return editedPhrase.GroupBy(q => q).ToDictionary(w => w.Key, w => w.Count()); //convert Ienumerable to dictionary where key is each word and value is a count
    }
}