using System;

/* Crea una clase llamada Libro con atributos titulo, autor y año_publicacion. 
Implementa un método que devuelva una descripción del libro y otro que verifique si el libro es considerado un clásico 
(publicado hace más de 50 años).
*/


public class Libro
{
    

 public string Titulo{get; set;}

 public string Autor{get; set;}

 private int añoPublicacion;
 public int AñoPublicacion
    {
        get {return añoPublicacion;}
        set
        {
            if (value >= 0)
            {
                añoPublicacion = value;
            }
        }
    }
    


   //CONSTRUCTOR 


   public Libro(string titulo, string autor, int añoPublicacion)
    {
        Titulo = titulo;    
        Autor = autor;
        AñoPublicacion = añoPublicacion;
    }


    public string Descripcion()
    {
        return $"Título: {Titulo}, Autor: {Autor}, Año de Publicación: {AñoPublicacion}";
    }
      
    public bool EsClasico()
    {
        int añoActual = DateTime.Now.Year;
        return (añoActual - AñoPublicacion) > 50;
    }
}

    public class Programa
    {
        static void Main()
        {

           Libro libro1 = new Libro ( "el libro troll ", "ELRUBIUSOMG", 2014 );

              Console.WriteLine(libro1.Descripcion());

                if (libro1.EsClasico())
                {
                    Console.WriteLine("El libro es un clásico.");
                }
                else
                {
                    Console.WriteLine("El libro no es un clásico.");
                }


        }
    }

