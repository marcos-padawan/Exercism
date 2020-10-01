using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        int hammingDistance = 0;
        if (firstStrand.Length != secondStrand.Length)
        {
            throw new ArgumentException();
        }
        else
        {
            for (int i =0; i < firstStrand.Length; i++)
            {
                hammingDistance += (firstStrand[i] != secondStrand[i]) ? 1 : 0;
            }
            return hammingDistance;
        }
    }
}