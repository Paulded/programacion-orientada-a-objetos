using System;
using System.Collections.Generic;

class Programa
{
    static void Main()
    {
        string[] palabras = { "casa", "perro", "gato", "programa", "juego" };
        Random random = new Random();

        string palabra = palabras[random.Next(palabras.Length)];

        List<char> progreso = new List<char>();

        
        for (int i = 0; i < palabra.Length; i++)
        {
            progreso.Add('_');
        }

        Console.WriteLine("Adivina la palabra:");

        while (progreso.Contains('_'))
        {
            Console.WriteLine(string.Join(" ", progreso));

            Console.Write("Ingresa una letra: ");
            char letra = char.ToLower(Console.ReadLine()[0]);

            bool acierto = false;

            for (int i = 0; i < palabra.Length; i++)
            {
                if (palabra[i] == letra)
                {
                    progreso[i] = letra;
                    acierto = true;
                }
            }

            if (!acierto)
            {
                Console.WriteLine("Letra incorrecta ❌");
            }
        }

        Console.WriteLine("¡Ganaste! La palabra era: " + palabra);
    }
}
