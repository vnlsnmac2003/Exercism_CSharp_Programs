using System;
using System.Collections.Generic;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        //Note: 
        //the input can contain non-letter characters i.e. numbers, special characters and whitespace
        //letters can repeat more than once

        //Pseudocode:
        //check whether the input is empty, if so return false
        //create a list of all the letters in the alphabet (a panagram list)
        //get the input and trim and make all letters lowercase
        //make cleaned input into a list
        //take a character from input and if it is not a letter move to the next one
        //when you have a letter check for a match and remove it
        //do previous 2 steps until the panagram list is empty and return true
        //if the input list iteration finishes before the panagram list is empty return false

        if (input.Length == 0)
        {
            return false;
        }

        List<char> pangramList = new List<char>("abcdefghijklmnopqrstuvwxyz");

        string cleanedInput = input.Trim().ToLower();
        List<char> userInput = new List<char>(cleanedInput);
        
        foreach (char letter in userInput)
        {
            if (!char.IsLetter(letter))
            {
                continue;
            }
            else
            {
                if (pangramList.Contains(letter))
                {
                    pangramList.Remove(letter);

                    if (pangramList.Count == 0)
                    {
                        return true;
                    }
                }
            }
        }

        return false;
    }
}
