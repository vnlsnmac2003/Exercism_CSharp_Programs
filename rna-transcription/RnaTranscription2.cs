using System;
using System.Linq;


class RnaTranscription2
{
    public static string ToRna(string nucleotide)
    {
        return new string(nucleotide.Select(x => Setter(x)).ToArray());
    }

    private static char Setter(char x)
    {
        switch (x)
        {
            case 'C':
                x = 'G'; break;
            case 'G':
                x = 'C'; break;
            case 'T':
                x = 'A'; break;
            case 'A':
                x = 'U'; break;
            default: throw new ArgumentException($"Invalid argument '{x}' specified.");
        }

        return x;
    }
}
