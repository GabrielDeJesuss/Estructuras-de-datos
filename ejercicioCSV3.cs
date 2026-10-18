sing System;
using System.IO;
class Program
{
    static void Main()
    {
        string ruta = "C:\\Users\\Usuario\\Documents\\Nueva carpeta\\archivos\\listaDeProductos.csv";
        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine("ID,Nombre,Precio,Cantidad");
            sw.WriteLine("12,Tablet,500,12");
            sw.WriteLine("8,Torre CPU,1200,5");
            sw.WriteLine("20,Ventilador,25,15");
            sw.WriteLine("2,Laptop,700,8");
            sw.WriteLine("5,Mouse,30,24");
        }
        string[] lineas = File.ReadAllLines(ruta);
        for (int i = 1; i < lineas.Length; i++)
        {
            string[] campos = lineas[i].Split(',');
            double precio = double.Parse(campos[2]);
            int cantidad = int.Parse(campos[3]);
            if (precio > 100)
                Console.WriteLine($"{campos[1]} - ${precio} - {cantidad}");
        }
    }
}
