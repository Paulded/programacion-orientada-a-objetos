/******************************************************************************
Escribe un programa que lea un número entero y determine si es positivo, negativo o cero.
*******************************************************************************/
using System;

class numerosjeje {
  static void Main() {
    Console.WriteLine("ingrese un numero: ");
    
    int numero = int.Parse(Console.ReadLine());
    
    comprobar(numero);
  }
  
  static void comprobar(int numero){
      
      if (numero < 0){
         Console.WriteLine("el numero es negativo");
        
      }
      else if (numero==0){
          Console.WriteLine("el numero es cero");
      }
      else {
         Console.WriteLine ("el numero es positivo");
      }
      }
}