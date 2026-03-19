//Escribe un programa que pida al usuario que ingrese una letra del alfabeto y determine si es una vocal o una consonante.
using System;




class numerosjeje {


    static void Main() {

       
        Console.WriteLine("ingresa una letra:");
        char letra = char.Parse(Console.ReadLine().ToLower());
        
       
            
            if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra== 'u'){

                Console.WriteLine("es una vocal");
            }
           
            else {
                Console.WriteLine("es consonante ");
            }
        }
    }