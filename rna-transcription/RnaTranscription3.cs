using System;
using System.Linq;


class RnaTranscription3
{
    public static string ToRna(string nucleotide)
    {
        return string.Concat( nucleotide.Select(x => Setter(x)) ); 
    }
    
    private static char Setter(char x)
    {
        return  (x == 'C') ? x = 'G' :
                (x == 'G') ? x = 'C' :
                (x == 'T') ? x = 'A' :
                (x == 'A') ? x = 'U' :
                throw new ArgumentException($"Invalid argument '{x}' specified.");
    }
}
