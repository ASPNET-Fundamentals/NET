using Multilenguaje;
using System;

namespace NETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un nombre: ");
            string nombre = Console.ReadLine();

            string respuesta = Saludos.Saludar(nombre);
            Console.WriteLine(respuesta);

            Console.ReadKey();
        }
    }
}
