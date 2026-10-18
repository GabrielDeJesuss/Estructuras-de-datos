//crear inventario.CSV
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = "C:\\Users\\Usuario\\Documents\\Nueva carpeta\\archivos\\inventario.csv";
        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine("ID,Nombre,Cantidad");
            sw.WriteLine("1,Laptop,5");
            sw.WriteLine("2,Mouse,15");
            sw.WriteLine("3,Teclado,8");
            sw.WriteLine("4,Monitor,12");
            sw.WriteLine("5,Torre,3");
            sw.WriteLine("6,Ventilador,14");
            sw.WriteLine("7,Tabled,6");
        }

        string[] lineas = File.ReadAllLines(ruta); //lee archivo

        Console.WriteLine("Productos con cantidad menor a 10:");

        for (int i = 1; i < lineas.Length; i++) //empezar en 1 omite encabezado
        {
            string[] campos = lineas[i].Split(',');

            string nombre = campos[1];
            int cantidad = int.Parse(campos[2]);

            if (cantidad < 10)
            {
                Console.WriteLine(
                    nombre + " - Cantidad: " + cantidad
                );
            }
        }
    }
}
