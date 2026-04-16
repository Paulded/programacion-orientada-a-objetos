//Escribe un programa que calcule la suma de los primeros 100 números naturales (es decir, 1 + 2 + 3 + ... + 100).
using System;

class numerosjeje
{
    
    static void Main()
    {
        int suma= 0;

        for (int i= 1; i <=100; i++)
        {
            suma= suma + i;
            
        }
        Console.WriteLine("la suma de los numeros es "+ suma);
    }
}