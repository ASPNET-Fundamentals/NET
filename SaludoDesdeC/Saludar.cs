using System;

namespace SaludoDesdeC
{
    public static class Saludar
    {
        public static string saludo(string nombre)
        {
            return string.Concat("Hola ", nombre, ", saludo de C#");
        }
    }
}
