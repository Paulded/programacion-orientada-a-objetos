using System;
/*
3)
Crea una clase llamada CuentaBancaria que tenga atributos como titular, saldo y numero_cuenta.
 Implementa métodos para depositar y retirar dinero, asegurándote de que el saldo no se vuelva negativo.


*/

public class CuentaBancaria
{
     public string Titular{get; set;}
     public string NumeroCuenta{get; set;}
     
     private double saldo;
     public double Saldo
     {
         get {return saldo;}
         set {
          
             if (value >= 0)
            saldo = value;
         }
         
         }
     
     
     //constructor
     
     public CuentaBancaria(string titular, string numeroCuenta, double saldo)
{
    Titular = titular;
    NumeroCuenta = numeroCuenta;
    Saldo = saldo;
}
 public void Depositar(double cantidad)
    {
        if (cantidad > 0)
        {
            Saldo += cantidad;
            Console.WriteLine($"Se han depositado {cantidad}. Saldo actual: {Saldo}");
        }
        else
        {
            Console.WriteLine("La cantidad a depositar debe ser positiva.");
        }
    }

    public void Retirar(double cantidad)
    {
        if (cantidad > 0)
        {
            if (Saldo >= cantidad)
            {
                Saldo -= cantidad;
                Console.WriteLine($"Se han retirado {cantidad}. Saldo actual: {Saldo}");
            }
            else
            {
                Console.WriteLine("No se puede retirar esa cantidad. Saldo insuficiente.");
            }
        }
        else
        {
            Console.WriteLine("La cantidad a retirar debe ser positiva.");
        }
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"el titular es{Titular}");
         Console.WriteLine($"el numero de cuenta  es{NumeroCuenta}");
          Console.WriteLine($"el saldo es{Saldo}");
    }
   

}
public class Programa{
    
    
    static void Main()
    {
         Console.WriteLine("ingresa el titular de la cuenta bancaria");
         string titular = Console.ReadLine()??"";
         
          Console.WriteLine("ingresa el numero de cuenta bancaria");
          string numeroCuenta = Console.ReadLine()??"";
          
            Console.WriteLine("ingresa el saldo de la cuenta bancaria");
          double saldo = double.Parse(Console.ReadLine());
          if (saldo < 0)
          {
              Console.WriteLine("El saldo no puede ser negativo. Se establecerá en 0.");
              saldo = 0;
          }
          
          CuentaBancaria cuenta1 = new CuentaBancaria(titular, numeroCuenta, saldo);
        
            
            cuenta1.MostrarInfo();


                Console.WriteLine("\nIngresa la cantidad a depositar");
        double cantidadDepositar = double.Parse(Console.ReadLine());
        cuenta1.Depositar(cantidadDepositar);

            Console.WriteLine("\nIngresa la cantidad a retirar");
        double cantidadRetirar = double.Parse(Console.ReadLine());
        cuenta1.Retirar(cantidadRetirar);

         Console.WriteLine("\nInformacion actualizada de la cuenta bancaria");
         cuenta1.MostrarInfo();
    }
}
