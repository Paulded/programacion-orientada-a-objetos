using System;
using System.Collections.Generic;
using System.Threading;

class Programa
{
    static void Main()
    {
        List<int> numeros = new List<int>();
        Random random = new Random();
        int cantidad = 5;

        
        for (int i = 0; i < cantidad; i++)
        {
            numeros.Add(random.Next(1, 10));
        }

        
        Console.WriteLine("Memoriza los números:");
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }

      
        Thread.Sleep(3000);

      
        Console.Clear();

        Console.WriteLine("Ahora ingresa los numeros en el mismo orden:");

        
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write("Numero " + (i + 1) + ": ");
            int intento = int.Parse(Console.ReadLine());

            if (intento != numeros[i])
            {
                Console.WriteLine("  Perdiste.");
                return;
            }
        }

        Console.WriteLine(" Ganaste.");
    }
}
