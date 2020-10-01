using System;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        bool armstrong = false;
        string numero = Convert.ToString(number);
        double soma = 0;
        for (int i = 0; i < numero.Length; i++)
        {
            soma += Math.Pow(Convert.ToInt32(numero[i].ToString()), numero.Length);
        }
        if (soma == Convert.ToDouble(number))
            armstrong = true;
        return armstrong;
    }
}