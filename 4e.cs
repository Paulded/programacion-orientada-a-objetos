using System;
using System.Collections.Generic;

class Programa
{
    static void Main()
    {
        List<int> numeros = new List<int>();
        int cantidad;

        Console.Write("¿Cuántos numeros queres ingresar?: ");
        cantidad = int.Parse(Console.ReadLine());

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write("Ingrese un numero: ");
            numeros.Add(int.Parse(Console.ReadLine()));
        }

        int contador = 0;

        foreach (int num in numeros)
        {
            if (num % 2 == 0)
            {
                contador++;
            }
        }

        Console.WriteLine("Cantidad de numeros pares: " + contador);
    }
}
