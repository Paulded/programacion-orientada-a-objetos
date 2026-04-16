using System;
//Escribe un programa que pida al usuario que ingrese números enteros positivos y luego calcule el producto de todos los números ingresados 
//hasta que el usuario ingrese un número negativo

class numerosjeje
{
    
static void Main()
    {
       int  suma = 0;
       int numero = 0 ;
        while (true)
        {
            
            Console.WriteLine("ingrese un numero: ");
             numero = int.Parse(Console.ReadLine());
             suma += numero;
            if (numero < 0)
            {
                Console.WriteLine("la suma de los numeros ingresados es: " + suma);
                break;
            }
        }
}
}