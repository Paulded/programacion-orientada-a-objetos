using System;

class Programa
{
    static void Main()
    {
        string[] opciones = { "piedra", "papel", "tijeras" };
        Random random = new Random();

        Console.WriteLine("Juego: Piedra, Papel o Tijeras");
        Console.Write("Elige (piedra, papel o tijeras): ");
        string usuario = Console.ReadLine().ToLower();

        string computadora = opciones[random.Next(0, 3)];

        Console.WriteLine("La computadora eligio: " + computadora);

        if (usuario == computadora)
        {
            Console.WriteLine("Empate");
        }
        else if (
            (usuario == "piedra" && computadora == "tijeras") ||
            (usuario == "papel" && computadora == "piedra") ||
            (usuario == "tijeras" && computadora == "papel")
        )
        {
            Console.WriteLine("Ganaste");
        }
        else if (
            usuario == "piedra" ||
            usuario == "papel" ||
            usuario == "tijeras"
        )
        {
            Console.WriteLine("Perdiste");
        }
        else
        {
            Console.WriteLine("Opción inválida");
        }
    }
}
