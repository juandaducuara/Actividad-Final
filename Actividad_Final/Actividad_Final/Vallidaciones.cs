using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Actividad_Final
{
    class Vallidaciones
    {
        public bool Vacio(string texto)
        {
            if (texto.Equals(""))
            {
                Console.WriteLine(" La entrada no puede ser VACIO");
                return false;
            }
            else
                return true;
        }

        public bool TipoNumero(string texto)
        {
            Regex regla = new Regex("[0-9]{1,9}(\\.[0-9]{0,2})?$");

            if (regla.IsMatch(texto))
                return true;
            else
            {
                Console.WriteLine(" La entrada debe ser una NUMERICA");
                return false;
            }
        }

        public bool TipoTexto(string texto)
        {
            Regex regla = new Regex("^[a-zA-Z ]*$");

            if (regla.IsMatch(texto))
                return true;
            else
            {
                Console.WriteLine(" La entrada debe ser SOLO TEXTO");
                return false;
            }
        }

        public bool SiNo(string texto)
        {
            texto.ToLower(); // convertimos la entra en minuscula 

            if (texto.Equals("s") || texto.Equals("n"))
                return true;
            else
            {
                Console.WriteLine(" La entrada debe ser S o N ");
                return false;
            }
        }
        public bool TipoNota(string texto)
        {
            Regex regla = new Regex(@"\A[0-5]{1}.{[0-9]{1}\Z");

            if (regla.IsMatch(texto))
                return true;
            else
            {
                Console.WriteLine(" La entrada debe ser NOTA");
                return false;
            }
        }
        public bool TipoCodigo(string texto)
        {
            Regex regla = new Regex(@"\A[0-9]{3}\Z");

            if (regla.IsMatch(texto))
                return true;
            else
            {
                Console.WriteLine(" La entrada debe ser NUMERICA");
                return false;
            }

        }
        public bool TipoCorreo(string texto)
        {
            Regex regla = new Regex(@"\A(\w+\.?\w*\@\w+\.)(com)\Z");

            if (regla.IsMatch(texto))
                return true;
            else
            {
                Console.WriteLine(" La entrada debe ser correo electronico");
                return false;
            }
        }
    }
}
