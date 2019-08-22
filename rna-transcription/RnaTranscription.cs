using System;
using System.Collections.Generic;
using System.Linq;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        List<int> C_Indexes = new List<int>(), 
                  G_Indexes = new List<int>(), 
                  T_Indexes = new List<int>(),
                  A_Indexes = new List<int>();

        for (int i = 0; i<nucleotide.Count(); i++)
        {
            char currentLetter = nucleotide.ElementAt(i);
            switch (currentLetter)
            {
                case 'C':
                 C_Indexes.Add(i); break;
                case 'G':
                    G_Indexes.Add(i); break;
                case 'T':
                    T_Indexes.Add(i); break;
                case 'A':
                    A_Indexes.Add(i); break;
                default: throw new ArgumentException($"Invalid argument '{currentLetter}' specified.");
            }
        }
        char[] nucleotideArray = nucleotide.ToArray();
        C_Indexes.ForEach(x => nucleotideArray[x] = 'G');
        G_Indexes.ForEach(x => nucleotideArray[x] = 'C');
        T_Indexes.ForEach(x => nucleotideArray[x] = 'A');
        A_Indexes.ForEach(x => nucleotideArray[x] = 'U');

        return new string(nucleotideArray);
    }
}