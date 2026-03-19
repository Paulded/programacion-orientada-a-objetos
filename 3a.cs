//Escribe un programa que pida al usuario que adivine un número secreto generado aleatoriamente. El programa debe dar pistas al usuario diciéndole si el número ingresado es mayor o menor que el número secreto.

using System;

class numerosjeje
{
    static void Main()
    {
        Random random = new Random();
        int secreto = random.Next(1, 11); // numero entre 1 y 10 porque no se especifico el rangoq jeje 

        int intento = 0;

        while (intento != secreto)
        {
            Console.WriteLine("Adivina el numero (1-10): ");
            intento = int.Parse(Console.ReadLine());

            if (intento < secreto)
            {
                Console.WriteLine("El numero es mayor");
            }
            else if (intento > secreto)
            {
                Console.WriteLine("El numero es menor");
            }
            else
            {
                Console.WriteLine("Correcto, adivinaste el numero");
            }
        }
    }
}