// This file was auto-generated based on version 1.3.0 of the canonical data.

using System;
using Xunit;

public class RnaTranscriptionTest2
{
    [Fact]
    public void Empty_rna_sequence()
    {
        Assert.Equal("", RnaTranscription2.ToRna(""));
    }

    [Fact]
    public void Rna_complement_of_cytosine_is_guanine()
    {
        Assert.Equal("G", RnaTranscription2.ToRna("C"));
    }

    [Fact]
    public void Rna_complement_of_guanine_is_cytosine()
    {
        Assert.Equal("C", RnaTranscription2.ToRna("G"));
    }

    [Fact]
    public void Rna_complement_of_thymine_is_adenine()
    {
        Assert.Equal("A", RnaTranscription2.ToRna("T"));
    }

    [Fact]
    public void Rna_complement_of_adenine_is_uracil()
    {
        Assert.Equal("U", RnaTranscription2.ToRna("A"));
    }

    [Fact]
    public void Rna_complement()
    {
        Assert.Equal("UGCACCAGAAUU", RnaTranscription2.ToRna("ACGTGGTCTTAA"));
    }

    [Fact]
    public void Rna_complement2()
    {
        Exception ex = Assert.Throws<ArgumentException>(() => RnaTranscription2.ToRna("ACGTGGTCPTAA"));
        Assert.Equal("Invalid argument 'P' specified.", ex.Message);
    }
}