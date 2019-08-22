using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class Acronym
{

    public static string Abbreviate(string phrase)
    {
        string acronym = "";
        phrase.Split(' ').ToList<string>().ForEach(
            x =>
            {
                if (x.Contains('-') && x.Length != 1)
                {
                    x.Split('-').ToList().ForEach(y => acronym += y.ElementAt(0));
                }
                else if (x.Length == 1 && !char.IsLetter(x[0]))
                {}
                else
                {
                    acronym += (!char.IsLetter(x[0])) ? x.ElementAt(1) : x.ElementAt(0);
                }
            }
        );
        return acronym.ToUpper();
    }
}