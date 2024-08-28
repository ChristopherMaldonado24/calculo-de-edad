using System;
using System.ComponentModel.Design;
class Proyecto
{


    static void Main(string[] args)
    {
        Console.WriteLine(" Bienvenido a el calculador de edades ");
        Console.WriteLine();
        Console.Write("Ingrese su nombre : ");
        string Nombre = Console.ReadLine();
        Console.Write(" Ingrese su edad: ");
        int Edad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        int EdadMeses = (Edad * 12);

        double EdadDias = (Edad * 365 );

        double EdadHoras = ((Edad * 365) * 24);

        Console.WriteLine($"{Nombre}");
        Console.WriteLine($" Su edad en meses es:{EdadMeses}");
        Console.WriteLine($" Su edad en meses es:{EdadDias}");
        Console.WriteLine($" Su edad en meses es:{EdadHoras}");
        Console.ReadKey();
    }
}