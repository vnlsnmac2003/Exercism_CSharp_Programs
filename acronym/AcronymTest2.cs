// This file was auto-generated based on version 1.7.0 of the canonical data.

using Xunit;

public class AcronymTest2
{
    [Fact]
    public void Basic()
    {
        Assert.Equal("PNG", Acronym2.Abbreviate("Portable Network Graphics"));
    }

    [Fact]
    public void Lowercase_words()
    {
        Assert.Equal("ROR", Acronym2.Abbreviate("Ruby on Rails"));
    }

    [Fact]
    public void Punctuation()
    {
        Assert.Equal("FIFO", Acronym2.Abbreviate("First In, First Out"));
    }

    [Fact]
    public void All_caps_word()
    {
        Assert.Equal("GIMP", Acronym2.Abbreviate("GNU Image Manipulation Program"));
    }

    [Fact]
    public void Punctuation_without_whitespace()
    {
        Assert.Equal("CMOS", Acronym2.Abbreviate("Complementary metal-oxide semiconductor"));
    }

    [Fact]
    public void Very_long_abbreviation()
    {
        Assert.Equal("ROTFLSHTMDCOALM", Acronym2.Abbreviate("Rolling On The Floor Laughing So Hard That My Dogs Came Over And Licked Me"));
    }

    [Fact]
    public void Consecutive_delimiters()
    {
        Assert.Equal("SIMUFTA", Acronym2.Abbreviate("Something - I made up from thin air"));
    }

    [Fact]
    public void Apostrophes()
    {
        Assert.Equal("HC", Acronym2.Abbreviate("Halley's Comet"));
    }

    [Fact]
    public void Underscore_emphasis()
    {
        Assert.Equal("TRNT", Acronym2.Abbreviate("The Road _Not_ Taken"));
    }
}