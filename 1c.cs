//Escribe un programa que pida al usuario que ingrese su edad y determine si es mayor de edad (18 años o más) o menor de edad.




class numerosjeje {


    static void Main() {

       
        Console.WriteLine("ingresa tu edad:");
        int edad = int.Parse(Console.ReadLine());
        
       
            
            if (edad >= 18){

                Console.WriteLine("eres mayor de edad");
            }
           
            else {
                Console.WriteLine("eres menor de edad");
            }
        }
    }