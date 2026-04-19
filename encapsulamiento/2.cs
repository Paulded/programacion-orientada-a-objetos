using System;
/*
Crea una clase llamada Persona con atributos nombre, edad y sexo.
 Implementa un método que permita cambiar la edad de la persona y otro 
 que muestre la información de la persona.

*/

public class Persona 
{
     public string Nombre{get; set;}
     public string Sexo{get; set;}
     
     private int edad;
     public int Edad
     {
         get {return edad;}
         set {
          
             if (value >= 0)
            edad = value;
         }
         
         }
     
     
     //constructor
     
     public Persona(string nombre, int edad, string sexo)
{
    Nombre = nombre;
    Edad = edad;
    Sexo = sexo;
}
     public void MostrarInformacion()
    {
         Console.WriteLine($"El nombre de la persona es {Nombre}");
         Console.WriteLine($"la edad de la persona es {Edad}");
         Console.WriteLine($"El sexo de la persona es {Sexo}");
    }

    public void CambiarEdad(int NuevaEdad)
    {
        Edad = NuevaEdad;
    }
}

    
   


public class Programa{
    
    
    static void Main()
    {
       Console.WriteLine("ingresa el nombre de la persona");
       string nombre = Console.ReadLine()??"";
       
        Console.WriteLine("ingresa la edad  de la persona");
         int edad = int.Parse(Console.ReadLine());
    
     Console.WriteLine("ingresa el sexo de la persona");
       string sexo = Console.ReadLine()??"";

       Persona persona1 = new Persona( nombre,  edad,  sexo);



       Console.WriteLine("\nInformacion de la persona");
       persona1.MostrarInformacion();
       
         Console.WriteLine("\nIngresa la nueva edad de la persona");
      int nuevaEdad = int.Parse(Console.ReadLine());
         persona1.CambiarEdad(nuevaEdad);
    
         Console.WriteLine("\nInformacion actualizada de la persona");
         persona1.MostrarInformacion();
       
        
    }
}