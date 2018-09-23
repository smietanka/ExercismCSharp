using System;
using System.Collections.Generic;
using System.Linq;

public class NucleotideCount
{
    private readonly string Sequence;
    public NucleotideCount(string sequence)
    {
        if (sequence.Except("ACGT").Count() > 0) throw new ArgumentException();
        Sequence = sequence;
    }

    public IDictionary<char, int> NucleotideCounts
    {
        get
        {
            var dict = Sequence.GroupBy(z => z).ToDictionary(x => x.Key, x => x.Count());
            if (!dict.ContainsKey('A')) dict.Add('A', 0);
            if (!dict.ContainsKey('C')) dict.Add('C', 0);
            if (!dict.ContainsKey('G')) dict.Add('G', 0);
            if (!dict.ContainsKey('T')) dict.Add('T', 0);
            return dict;
        }
    }
}