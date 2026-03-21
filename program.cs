using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el nombre del cliente:");
        string nombre = Console.ReadLine();

        Console.WriteLine("Ingrese la edad del cliente:");
        int edad = int.Parse(Console.ReadLine());

        if (edad >= 18)
        {
            Console.WriteLine("Cliente: " + nombre + " es mayor de edad");
        }
        else
        {
            Console.WriteLine("Cliente: " + nombre + " es menor de edad");
        }
    }
}
