using System;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {
        string fraseRetorno = String.Empty;
        for (int i = 0; i < takeDown; i++)
        {
            if (takeDown == 1)
            {
                if (startBottles - (i + 1) == 1)
                {
                    fraseRetorno += $"{startBottles - i} bottles of beer on the wall, {startBottles - i} bottles of beer.\n" + $"Take one down and pass it around, {startBottles - (i + 1)} bottle of beer on the wall.";
                }
                else if (startBottles - (i + 1) == 0)
                {
                    fraseRetorno += $"{startBottles - i} bottle of beer on the wall, {startBottles - i} bottle of beer.\n" + "Take it down and pass it around, no more bottles of beer on the wall.";
                }
                else if (startBottles - (i + 1) == -1)
                {
                    fraseRetorno += "No more bottles of beer on the wall, no more bottles of beer.\n" + "Go to the store and buy some more, 99 bottles of beer on the wall.";
                }
                else
                {
                    fraseRetorno += $"{startBottles - i} bottles of beer on the wall, {startBottles - i} bottles of beer.\n" + $"Take one down and pass it around, {startBottles - (i + 1)} bottles of beer on the wall.";
                }
            }
            if (takeDown > 1)
            {
                if (startBottles - (i + 1) == 1)
                {
                    fraseRetorno += $"{startBottles - i} bottles of beer on the wall, {startBottles - i} bottles of beer.\n" + $"Take one down and pass it around, {startBottles - (i + 1)} bottle of beer on the wall.\n\n";
                }
                else if (startBottles - (i + 1) == 0)
                {
                    fraseRetorno += $"{startBottles - i} bottle of beer on the wall, {startBottles - i} bottle of beer.\n" + "Take it down and pass it around, no more bottles of beer on the wall.\n\n";
                }
                else if (startBottles - (i + 1) == -1)
                {
                    fraseRetorno += "No more bottles of beer on the wall, no more bottles of beer.\n" + "Go to the store and buy some more, 99 bottles of beer on the wall.";
                }
                else
                {
                    if (i == (takeDown - 1))
                        fraseRetorno += $"{startBottles - i} bottles of beer on the wall, {startBottles - i} bottles of beer.\n" + $"Take one down and pass it around, {startBottles - (i + 1)} bottles of beer on the wall.";
                    else
                        fraseRetorno += $"{startBottles - i} bottles of beer on the wall, {startBottles - i} bottles of beer.\n" + $"Take one down and pass it around, {startBottles - (i + 1)} bottles of beer on the wall.\n\n";
                }
            }
        }
        return fraseRetorno;
    }
}