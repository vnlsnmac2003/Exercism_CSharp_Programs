// This file was auto-generated based on version 2.0.0 of the canonical data.

using Xunit;

public class ImprovedPangramTest
{

    [Fact]
    public void Empty_sentence()
    {
        Assert.False(ImprovedPangram.IsPangram(""));
    }

    [Fact]
    public void Perfect_lower_case()
    {
        Assert.True(ImprovedPangram.IsPangram("abcdefghijklmnopqrstuvwxyz"));
    }

    [Fact]
    public void Only_lower_case()
    {
        Assert.True(ImprovedPangram.IsPangram("the quick brown fox jumps over the lazy dog"));
    }

    [Fact]
    public void Missing_the_letter_x()
    {
        Assert.False(ImprovedPangram.IsPangram("a quick movement of the enemy will jeopardize five gunboats"));
    }

    [Fact]
    public void Missing_the_letter_h()
    {
        Assert.False(ImprovedPangram.IsPangram("five boxing wizards jump quickly at it"));
    }

    [Fact]
    public void With_underscores()
    {
        Assert.True(ImprovedPangram.IsPangram("the_quick_brown_fox_jumps_over_the_lazy_dog"));
    }

    [Fact]
    public void With_numbers()
    {
        Assert.True(ImprovedPangram.IsPangram("the 1 quick brown fox jumps over the 2 lazy dogs"));
    }

    [Fact]
    public void Missing_letters_replaced_by_numbers()
    {
        Assert.False(ImprovedPangram.IsPangram("7h3 qu1ck brown fox jumps ov3r 7h3 lazy dog"));
    }

    [Fact]
    public void Mixed_case_and_punctuation()
    {
        Assert.True(ImprovedPangram.IsPangram("\"Five quacking Zephyrs jolt my wax bed.\""));
    }

    [Fact]
    public void Case_insensitive()
    {
        Assert.False(ImprovedPangram.IsPangram("the quick brown fox jumps over with lazy FX"));
    }

}