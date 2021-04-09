using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_Final
{
    class pantallas
    {
        public void pantallaprincipal()
        {
            
            for (int i = 30; i <= 79; i++)
            {
                Console.SetCursorPosition(i, 0); Console.WriteLine("═");//primero
                Console.SetCursorPosition(i, 1); Console.WriteLine("¤");
                Console.SetCursorPosition(i, 3); Console.WriteLine("*");
                Console.SetCursorPosition(i, 4); Console.WriteLine("═");
                Console.SetCursorPosition(i, 5); Console.WriteLine("▀");//agregar estudiante
                Console.SetCursorPosition(i, 11); Console.WriteLine("▄");
                Console.SetCursorPosition(i, 12); Console.WriteLine("═");
                Console.SetCursorPosition(i, 13); Console.WriteLine("▀");//agregar estudiante
                Console.SetCursorPosition(i, 17); Console.WriteLine("▄");
                Console.SetCursorPosition(i, 18); Console.WriteLine("═");
                Console.SetCursorPosition(i, 29); Console.WriteLine("═");//ultimo
                Console.SetCursorPosition(i, 28); Console.WriteLine("▄");
                Console.SetCursorPosition(i, 25); Console.WriteLine("═");
                Console.SetCursorPosition(i, 26); Console.WriteLine("▀");
            }
            for (int i = 1; i <= 28; i++)
            {
                Console.SetCursorPosition(30, i); Console.WriteLine("║");

                Console.SetCursorPosition(80, i); Console.WriteLine("║");
            }
            //esquinas
            Console.SetCursorPosition(30, 29); Console.Write("╚");
            Console.SetCursorPosition(80, 29); Console.Write("╝");
            Console.SetCursorPosition(30, 0); Console.Write("╔");
            Console.SetCursorPosition(80, 0); Console.Write("╗");
            //casilla
            Console.SetCursorPosition(53, 21); Console.Write("╚");
            Console.SetCursorPosition(57, 21); Console.Write("╝");
            Console.SetCursorPosition(53, 19); Console.Write("╔");
            Console.SetCursorPosition(57, 19); Console.Write("╗");
            //aristar
            Console.SetCursorPosition(30, 4); Console.Write("╠");
            Console.SetCursorPosition(80, 4); Console.Write("╣");
            Console.SetCursorPosition(30, 12); Console.Write("╠");
            Console.SetCursorPosition(80, 12); Console.Write("╣");
            Console.SetCursorPosition(30, 18); Console.Write("╠");
            Console.SetCursorPosition(80, 18); Console.Write("╣");
            Console.SetCursorPosition(30, 25); Console.Write("╠");
            Console.SetCursorPosition(80, 25); Console.Write("╣");
        }
        public void pantallatablas()
        {
            for (int i = 0; i <= 109; i++)
            {
                Console.SetCursorPosition(i, 0); Console.WriteLine("═");//primero
                Console.SetCursorPosition(i, 1); Console.WriteLine("¤");
                Console.SetCursorPosition(i, 3); Console.WriteLine("*");
                Console.SetCursorPosition(i, 4); Console.WriteLine("═");
                Console.SetCursorPosition(i, 6); Console.WriteLine("═");
                Console.SetCursorPosition(i, 29); Console.WriteLine("═");//ultimo
                Console.SetCursorPosition(i, 28); Console.WriteLine("▄");
                Console.SetCursorPosition(i, 25); Console.WriteLine("═");
                Console.SetCursorPosition(i, 26); Console.WriteLine("▀");
            }
            for (int i = 1; i <= 28; i++)
            {
                Console.SetCursorPosition(0, i); Console.WriteLine("║");
                Console.SetCursorPosition(110, i); Console.WriteLine("║");
            }
            for (int i = 5; i <= 24; i++)
            {
                Console.SetCursorPosition(9, i); Console.WriteLine("║");
                Console.SetCursorPosition(36, i); Console.WriteLine("║");
                Console.SetCursorPosition(59, i); Console.WriteLine("║");
                Console.SetCursorPosition(68, i); Console.WriteLine("║");
                Console.SetCursorPosition(77, i); Console.WriteLine("║");
                Console.SetCursorPosition(86, i); Console.WriteLine("║");
                Console.SetCursorPosition(99, i); Console.WriteLine("║");
            }
            //esquinas
            Console.SetCursorPosition(0, 29); Console.Write("╚");
            Console.SetCursorPosition(110, 29); Console.Write("╝");
            Console.SetCursorPosition(0, 0); Console.Write("╔");
            Console.SetCursorPosition(110, 0); Console.Write("╗");
            Console.SetCursorPosition(9, 4); Console.Write("╦");
            Console.SetCursorPosition(9, 6); Console.Write("╬");
            Console.SetCursorPosition(9, 25); Console.Write("╩");
            Console.SetCursorPosition(36, 4); Console.Write("╦");
            Console.SetCursorPosition(36, 6); Console.Write("╬");
            Console.SetCursorPosition(36, 25); Console.Write("╩");
            Console.SetCursorPosition(59, 4); Console.Write("╦");
            Console.SetCursorPosition(59, 6); Console.Write("╬");
            Console.SetCursorPosition(59, 25); Console.Write("╩");
            Console.SetCursorPosition(99, 4); Console.Write("╦");
            Console.SetCursorPosition(99, 6); Console.Write("╬");
            Console.SetCursorPosition(99, 25); Console.Write("╩");
            Console.SetCursorPosition(86, 4); Console.Write("╦");
            Console.SetCursorPosition(86, 6); Console.Write("╬");
            Console.SetCursorPosition(86, 25); Console.Write("╩");
            Console.SetCursorPosition(77, 4); Console.Write("╦");
            Console.SetCursorPosition(77, 6); Console.Write("╬");
            Console.SetCursorPosition(77, 25); Console.Write("╩");
            Console.SetCursorPosition(68, 4); Console.Write("╦");
            Console.SetCursorPosition(68, 6); Console.Write("╬");
            Console.SetCursorPosition(68, 25); Console.Write("╩");
            Console.SetCursorPosition(0, 4); Console.Write("╠");
            Console.SetCursorPosition(0, 6); Console.Write("╠");
            Console.SetCursorPosition(110, 4); Console.Write("╣");
            Console.SetCursorPosition(110, 6); Console.Write("╣");
            Console.SetCursorPosition(0, 25); Console.Write("╠");
            Console.SetCursorPosition(110, 25); Console.Write("╣");
            Console.SetCursorPosition(45, 27); Console.Write("Juan David Ducuara Molina®");
        }
        public void pantalladatos()
        {

            for (int i = 30; i <= 79; i++)
            {
                Console.SetCursorPosition(i, 0); Console.WriteLine("═");//primero
                Console.SetCursorPosition(i, 1); Console.WriteLine("¤");
                Console.SetCursorPosition(i, 3); Console.WriteLine("*");
                Console.SetCursorPosition(i, 4); Console.WriteLine("═");
                Console.SetCursorPosition(i, 5); Console.WriteLine("▀");//agregar estudiante
                Console.SetCursorPosition(50, 2); Console.WriteLine("HAPPY NOTE");
                Console.SetCursorPosition(46, 7); Console.WriteLine("Crear Estudiante");
                Console.SetCursorPosition(i, 9); Console.WriteLine("▄");
                Console.SetCursorPosition(i, 10); Console.WriteLine("═");
                Console.SetCursorPosition(i, 11); Console.WriteLine("▀");//agregar estudiante
                Console.SetCursorPosition(i, 15); Console.WriteLine("▄");
                Console.SetCursorPosition(i, 16); Console.WriteLine("═");
                Console.SetCursorPosition(i, 29); Console.WriteLine("═");//ultimo
                Console.SetCursorPosition(i, 28); Console.WriteLine("▄");
                Console.SetCursorPosition(i, 25); Console.WriteLine("═");
                
                Console.SetCursorPosition(i, 26); Console.WriteLine("▀");
            }
            for (int i = 1; i <= 28; i++)
            {
                Console.SetCursorPosition(30, i); Console.WriteLine("║");

                Console.SetCursorPosition(80, i); Console.WriteLine("║");
            }
            //esquinas
            Console.SetCursorPosition(30, 29); Console.Write("╚");
            Console.SetCursorPosition(80, 29); Console.Write("╝");
            Console.SetCursorPosition(30, 0); Console.Write("╔");
            Console.SetCursorPosition(80, 0); Console.Write("╗");
            
            //aristar
            Console.SetCursorPosition(30, 4); Console.Write("╠");
            Console.SetCursorPosition(80, 4); Console.Write("╣");
            Console.SetCursorPosition(30, 10); Console.Write("╠");
            Console.SetCursorPosition(80, 10); Console.Write("╣");
            Console.SetCursorPosition(30, 16); Console.Write("╠");
            Console.SetCursorPosition(80, 16); Console.Write("╣");
            Console.SetCursorPosition(30, 25); Console.Write("╠");
            Console.SetCursorPosition(80, 25); Console.Write("╣");
            Console.SetCursorPosition(50, 27); Console.Write("J D D M®");
        }
        public void pantallabuscar()
        {

            for (int i = 30; i <= 79; i++)
            {
                Console.SetCursorPosition(i, 0); Console.WriteLine("═");//primero
                Console.SetCursorPosition(i, 1); Console.WriteLine("¤");
                Console.SetCursorPosition(i, 3); Console.WriteLine("*");
                Console.SetCursorPosition(i, 4); Console.WriteLine("═");
                Console.SetCursorPosition(i, 5); Console.WriteLine("▀");//agregar estudiante
                Console.SetCursorPosition(50, 2); Console.WriteLine("HAPPY NOTE");
                Console.SetCursorPosition(46, 7); Console.WriteLine("Buscar estudiante");
                Console.SetCursorPosition(i, 9); Console.WriteLine("▄");
                Console.SetCursorPosition(i, 10); Console.WriteLine("═");
                Console.SetCursorPosition(i, 11); Console.WriteLine("▀");//agregar estudiante
                Console.SetCursorPosition(i, 15); Console.WriteLine("▄");
                Console.SetCursorPosition(i, 16); Console.WriteLine("═");
                Console.SetCursorPosition(i, 29); Console.WriteLine("═");//ultimo
                Console.SetCursorPosition(i, 28); Console.WriteLine("▄");
                Console.SetCursorPosition(i, 25); Console.WriteLine("═");

                Console.SetCursorPosition(i, 26); Console.WriteLine("▀");
            }
            for (int i = 1; i <= 28; i++)
            {
                Console.SetCursorPosition(30, i); Console.WriteLine("║");

                Console.SetCursorPosition(80, i); Console.WriteLine("║");
            }
            //esquinas
            Console.SetCursorPosition(30, 29); Console.Write("╚");
            Console.SetCursorPosition(80, 29); Console.Write("╝");
            Console.SetCursorPosition(30, 0); Console.Write("╔");
            Console.SetCursorPosition(80, 0); Console.Write("╗");

            //aristar
            Console.SetCursorPosition(30, 4); Console.Write("╠");
            Console.SetCursorPosition(80, 4); Console.Write("╣");
            Console.SetCursorPosition(30, 10); Console.Write("╠");
            Console.SetCursorPosition(80, 10); Console.Write("╣");
            Console.SetCursorPosition(30, 16); Console.Write("╠");
            Console.SetCursorPosition(80, 16); Console.Write("╣");
            Console.SetCursorPosition(30, 25); Console.Write("╠");
            Console.SetCursorPosition(80, 25); Console.Write("╣");
            Console.SetCursorPosition(50, 27); Console.Write("J D D M®");
        }
        public void pantallaactualiz()
        {
            for (int i = 0; i <= 109; i++)
            {
                Console.SetCursorPosition(i, 0); Console.WriteLine("═");//primero
                Console.SetCursorPosition(i, 1); Console.WriteLine("¤");
                Console.SetCursorPosition(i, 3); Console.WriteLine("*");
                Console.SetCursorPosition(i, 4); Console.WriteLine("═");
                Console.SetCursorPosition(i, 6); Console.WriteLine("═");
                Console.SetCursorPosition(i, 29); Console.WriteLine("═");//ultimo
                Console.SetCursorPosition(i, 28); Console.WriteLine("▄");
                Console.SetCursorPosition(i, 25); Console.WriteLine("═");
                Console.SetCursorPosition(i, 26); Console.WriteLine("▀");
            }
            for (int i = 1; i <= 28; i++)
            {
                Console.SetCursorPosition(0, i); Console.WriteLine("║");
                Console.SetCursorPosition(110, i); Console.WriteLine("║");
            }
            Console.SetCursorPosition(0, 29); Console.Write("╚");
            Console.SetCursorPosition(110, 29); Console.Write("╝");
            Console.SetCursorPosition(0, 0); Console.Write("╔");
            Console.SetCursorPosition(110, 0); Console.Write("╗");
            Console.SetCursorPosition(0, 4); Console.Write("╠");
            Console.SetCursorPosition(0, 6); Console.Write("╠");
            Console.SetCursorPosition(110, 4); Console.Write("╣");
            Console.SetCursorPosition(110, 6); Console.Write("╣");
            Console.SetCursorPosition(0, 25); Console.Write("╠");
            Console.SetCursorPosition(110, 25); Console.Write("╣");
            Console.SetCursorPosition(45, 27); Console.Write("Juan David Ducuara Molina®");
            Console.SetCursorPosition(20, 8); Console.Write(" - Datos Antiguos - ");
            Console.SetCursorPosition(70, 8); Console.Write("+ Datos actualizados +");
            Console.SetCursorPosition(10, 10); Console.Write("Nombre: ");
            Console.SetCursorPosition(10, 12); Console.Write("Correo:");
            Console.SetCursorPosition(10, 14); Console.Write("Nota 1:");
            Console.SetCursorPosition(10, 16); Console.Write("Nota 2:");
            Console.SetCursorPosition(10, 18); Console.Write("Nota 3:"); ;
            
        }
    }
}
