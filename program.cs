using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el nombre del cliente:");
        string nombre = Console.ReadLine();

        Console.WriteLine("Ingrese la edad del cliente:");
        int edad = int.Parse(Console.ReadLine());

        Console.WriteLine("Cliente: " + nombre);
        Console.WriteLine("Edad: " + edad);
    }
}
