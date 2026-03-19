//Escribe un programa que pida al usuario que ingrese un número y luego muestre la suma de los números impares desde 1 hasta ese número.


using System;

class numerosjeje
{
    
    static void Main()
    {
        Console.WriteLine("ingrese un numero: ");
        int numero = int.Parse(Console.ReadLine());

        int suma = 0;
        for (int i =1;i < numero; i++)
        {
            if (i% 2 == 1)
            {
                suma += i;
            }
        }
        Console.WriteLine("La suma de los numeros impares "+ suma);
    }
}