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

        int suma = 0;

        foreach (int num in numeros)
        {
            suma += num;
        }

        double promedio = (double)suma / numeros.Count;

        Console.WriteLine("La media es: " + promedio);
    }
}
