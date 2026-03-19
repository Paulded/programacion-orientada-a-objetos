//Escribe un programa que muestre las tablas de multiplicar del 1 al 10.
using System;

class numerosjeje
{
    
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("tabla del "+ i );
        

        for(int j= 1; j <= 10; j++)
        {
            Console.WriteLine(i+"x"+j+"="+(i*j));
        }
    } 
    }
}