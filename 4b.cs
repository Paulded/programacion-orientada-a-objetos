using System;

class Programajeje
{
    static void Main()
    {
        int[] numeros = { 5, 10, 3, 20, 8 };
        int maximo = numeros[0];

        foreach (int num in numeros)
        {
            if (num > maximo)
            {
                maximo = num;
            }
        }

        Console.WriteLine("El máximo es: " + maximo);
    }
}
