using System;
using System.Collections.Generic;
using System.Linq;

public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    private readonly int Mask;

    public Allergies(int mask)
    {
        Mask = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return List().Contains(allergen);
    }

    public Allergen[] List()
    {
        if (Mask == 0)
            return new Allergen[0];

        List<Allergen> listaAlergias = new List<Allergen>();

        string aux = reverseString(Mask);
        for (int i = 0; i < aux.Length; i++)
        {
            if (aux[i] == '1')
            {
                foreach (var item in Enum.GetValues(typeof(Allergen)))
                {
                    if (Convert.ToInt32(item) == Math.Pow(2, i))
                    {
                        listaAlergias.Add((Allergen)item);
                    }
                }
            }
        }
        return listaAlergias.ToArray();
    }

    public static string reverseString(int numero)
    {
        string Word = Convert.ToString(numero, 2);
        char[] arrayChar = Word.ToCharArray();
        Array.Reverse(arrayChar);
        string invertida = new string(arrayChar);

        return invertida;
    }
}