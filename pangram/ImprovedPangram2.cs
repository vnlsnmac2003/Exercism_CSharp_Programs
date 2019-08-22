using System;
using System.Collections.Generic;
using System.Text;

class ImprovedPangram2
{
    public static bool IsPangram(string s) =>
        new HashSet<char>(s.ToLower())
            .IsSupersetOf("abcdefghijklmnopqrstuvwxyz");
}

