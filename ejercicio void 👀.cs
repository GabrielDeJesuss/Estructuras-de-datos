using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Clase210822_2
{
    internal class Program
    {
        //ejercicio static void 👀
        static void ImprimirCabecera(string nombreMateria, int grupo, string nombre)
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("            UNIVERSIDAD DEL CARIBE        ");
            Console.WriteLine($" Asignatura: {nombreMateria}");
            Console.WriteLine($" Grupo: {grupo}");
            Console.WriteLine($" Nombre: {nombre}");
            Console.WriteLine("==============================================");
        }
        static void Main(string[] args)
        {
            //Llamar al procedimiento ImprimirCabecera
            ImprimirCabecera("Fundamentos de programación", 1, "Gabriel Medina");
        }
    }
}
