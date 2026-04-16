using System;

class Programajeje
{
    static void Main()
    {
        int[] numeros = { 5, 10, 15, 20, 25 }; 
        int suma = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            suma += numeros[i];
        }

        Console.WriteLine("La suma de los elementos es: " + suma);
    }
}
