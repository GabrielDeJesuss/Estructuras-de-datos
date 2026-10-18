//analizar y determinar campos
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = "C:\\Users\\Usuario\\Documents\\Nueva carpeta\\archivos\\listaDeProductos.csv";

        if (File.Exists(ruta))
        {
            string[] lineas = File.ReadAllLines(ruta); //lee todas las lineas

            string[] encabezados = lineas[0].Split(','); //separa los encabezados por comas

            Console.WriteLine("Campos del archivo:");

            foreach (string campo in encabezados)
            {
                Console.WriteLine(campo);
            }

            Console.WriteLine("Delimitador: coma (,)");
            Console.WriteLine("");
            Console.WriteLine("Tipos de datos:");
            Console.WriteLine("-ID: int");
            Console.WriteLine("-Producto: string");
            Console.WriteLine("-precio: double");
            Console.WriteLine("-cantidad: int");
        }
        else
        {
            Console.WriteLine("El archivo no existe.");
        }
    }
}
