using Multilenguaje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFramework
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
