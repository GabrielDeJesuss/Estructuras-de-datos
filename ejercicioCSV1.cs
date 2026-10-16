using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creacionDeArchivo
{
    class Program
    {
        static void Main()
        {
            string ruta = "C:\\Users\\Sala-1\\Desktop\\archivos\\informacion_estudiantes.csv";
            using (StreamWriter sw = new StreamWriter(ruta))
            {
                sw.WriteLine("Nombre,Edad,Nota,semestre");
                sw.WriteLine("Gabriel,23,72,2do");
                sw.WriteLine("Katerin,21,80,4to");
                sw.WriteLine("Geronimo,18,60,1ro");
            }
            Console.WriteLine("Archivo creado exitosamente.");
        }
    }
}
