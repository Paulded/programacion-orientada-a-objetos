using System;
using System.Collections.Generic;

class Programa
{
    static void Main()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);

        List<int> intentos = new List<int>();
        int intento = 0;

        Console.WriteLine("Adivina el numero (entre 1 y 100)");

        while (intento != numeroSecreto)
        {
            Console.Write("Ingresa tu numero: ");
            intento = int.Parse(Console.ReadLine());

            intentos.Add(intento); 

            if (intento > numeroSecreto)
            {
                Console.WriteLine("El número es menor");
            }
            else if (intento < numeroSecreto)
            {
                Console.WriteLine("El número es mayor");
            }
            else
            {
                Console.WriteLine(" Adivinaste el número ");
            }
        }

        Console.WriteLine("Cantidad de intentos: " + intentos.Count);

        Console.WriteLine("Tus intentos fueron:");
        foreach (int num in intentos)
        {
            Console.Write(num + " ");
        }
    }
}
