using System;
using System.Linq;
using System.Collections.Generic;


class RnaTranscription4
{
    public static string ToRna(string nucleotide)
    {
        return string.Concat(nucleotide.Select(x => ("CGTA".Contains(x) ? RnaCodes[x] : 
        throw new ArgumentException($"Invalid argument '{x}' specified."))));
    }

    private static readonly Dictionary<char, char> RnaCodes = new Dictionary<char,char>()
    {
        {'C', 'G'}, {'G', 'C'}, {'T', 'A'}, {'A','U'}
    };
}
