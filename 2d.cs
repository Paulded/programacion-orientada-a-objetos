//Escribe un programa que pida al usuario que ingrese una palabra y luego muestre cada letra de la palabra en una línea separada.
using System;

class palabrasjeje
{
    
    static void Main()
    {
        Console.WriteLine("ingresa una palabra");
        string palabra= Console.ReadLine();

        for (int i= 0; i < palabra.Length; i++)
        {
            Console.WriteLine(palabra[i]);
        }
    }
}