using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecturaDeArchivo
{
    class Program
    {
        static void Main()
        {
            string ruta = "C:\\Users\\Sala-1\\Desktop\\archivos\\informacion_estudiantes.csv";
            if (File.Exists(ruta))
            {
                string[] lineas = File.ReadAllLines(ruta);
                foreach (string linea in lineas)
                {
                    string[] campos = linea.Split(',');
                    Console.WriteLine($"Nombre: {campos[0]}, Nota: {campos[2]}");
                }
            }
            using (StreamWriter sw = new StreamWriter("C:\\Users\\Sala-1\\Desktop\\archivos\\informacion_estudiantes.csv", append: true))
            {
                sw.WriteLine("Juanito, 22, 65, 3ro");
            }
        }
    }
}
