using System;
using System.Collections.Generic;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        IEnumerable<char> input = word.ToLower().Where(char.IsLetter); //get all lowercase letters
        return input.Distinct().Count() == input.Count(); //Find out whether all letters are unique
    }
}
