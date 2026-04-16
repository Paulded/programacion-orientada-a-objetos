using System;
//Escribe un programa que pida al usuario que ingrese dos numeros y determine cual es el numero mas grande.



class numerosjeje {


    static void Main() {

       
        Console.WriteLine("ingresa el 1er numero:");
        int numero = int.Parse(Console.ReadLine());
        
        Console.WriteLine("ingresa el 2do numero:");
         int numero2 = int.Parse(Console.ReadLine());
            
            if (numero>numero2 ){

                Console.WriteLine("el numero 1 es mayor que el numero 2");
            }
            else if (numero2 > numero ){

                Console.WriteLine("el numero 2 es mayor que el numero 1 ");
            }
            else {
                Console.WriteLine("ambos numeros son iguales");
            }
        }
    }
