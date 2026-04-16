using System;
/*Escribe un programa que pida al usuario que ingrese un número del 1 al 7
y determine a qué día de la semana corresponde (1 es lunes, 2 es martes, etc.).
Si el número no está en ese rango, el programa debe mostrar un mensaje de error.*/





class numerosjeje{
    
    static bool verificar(int numero){
        
        if (numero > 7 || numero < 1){
            
            return true;
            
        }
        return false;
    }
    
    
    static void Main(){
        
        
        
        Console.WriteLine("ingrese un numero del 1 al 7");
        int numero = int.Parse(Console.ReadLine());
        
        if(verificar(numero)){
            Console.WriteLine("el numero no esta en el rango jeje");
        }
        
        else {
           
            switch (numero)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
            }
        
    
        }
    }
}







