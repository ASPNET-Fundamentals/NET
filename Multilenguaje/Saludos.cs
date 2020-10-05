using System;
using System.Text;

namespace Multilenguaje
{
    public static class Saludos
    {

        public static string Saludar(string nombre)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(SaludoDesdeF.Saludar.saludo(nombre));
            sb.Append(Environment.NewLine);
            sb.Append(SaludoDesdeVB.Saludar.saludo(nombre));
            sb.Append(Environment.NewLine);
            sb.Append(SaludoDesdeC.Saludar.saludo(nombre));

            return sb.ToString();
        }
    }
}
