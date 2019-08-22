using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

    public static class CorrectedPangram
    {
        public static bool IsPangram(string input)
        {
            const string pangramList = "abcdefghijklmnopqrstuvwxyz";
            string userInput = input.ToLower();
            return pangramList.All(userInput.Contains);
        }
    }
