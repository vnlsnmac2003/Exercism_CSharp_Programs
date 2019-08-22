// This file was auto-generated based on version 1.3.0 of the canonical data.

using System;
using Xunit;

public class RnaTranscriptionTest3
{
    [Fact]
    public void Empty_rna_sequence()
    {
        Assert.Equal("", RnaTranscription3.ToRna(""));
    }

    [Fact]
    public void Rna_complement_of_cytosine_is_guanine()
    {
        Assert.Equal("G", RnaTranscription3.ToRna("C"));
    }

    [Fact]
    public void Rna_complement_of_guanine_is_cytosine()
    {
        Assert.Equal("C", RnaTranscription3.ToRna("G"));
    }

    [Fact]
    public void Rna_complement_of_thymine_is_adenine()
    {
        Assert.Equal("A", RnaTranscription3.ToRna("T"));
    }

    [Fact]
    public void Rna_complement_of_adenine_is_uracil()
    {
        Assert.Equal("U", RnaTranscription3.ToRna("A"));
    }

    [Fact]
    public void Rna_complement()
    {
        Assert.Equal("UGCACCAGAAUU", RnaTranscription3.ToRna("ACGTGGTCTTAA"));
    }

    [Fact]
    public void Rna_complement2()
    {
        Exception ex = Assert.Throws<ArgumentException>(() => RnaTranscription3.ToRna("ACGTGGTCPTAA"));
        Assert.Equal("Invalid argument 'P' specified.", ex.Message);
    }
}