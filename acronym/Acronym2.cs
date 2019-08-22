using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


public static class Acronym2
{

    public static string Abbreviate(string phrase)
    {
        String acronym = "";
        char[] seperators = { ' ', '_', '-' };
        phrase.Split(seperators, StringSplitOptions.RemoveEmptyEntries).ToList<string>().ForEach(x => acronym += x[0]);
        return acronym.ToUpper();
    }
}