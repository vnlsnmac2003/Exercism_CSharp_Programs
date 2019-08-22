using System.Linq;


public static class ImprovedPangram
{
    const string alphabet = "abcdefghijklmnopqrstuvwxyz";
    public static bool IsPangram(string text)
    {
        return alphabet.All(text.ToLower().Contains);
    }
}
