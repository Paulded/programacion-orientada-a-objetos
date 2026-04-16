using System;

class Programajeje
{
    static void Main()
    {
        int[] numeros = { 5, 10, 3, 20, 8 };
        int minimo = numeros[0];

        foreach (int num in numeros)
        {
            if (num < minimo)
            {
                minimo = num;
            }
        }

        Console.WriteLine("El mínimo es: " + minimo);
    }
}
