// ventas, total y producto mas vendido
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = "C:\\Users\\Usuario\\Documents\\Nueva carpeta\\archivos\\ventas.txt";

        if (File.Exists(ruta))
        {
            string[] lineas = File.ReadAllLines(ruta);

            int total = 0;
            string productoMasVendido = "";
            int mayorCantidad = 0;

            foreach (string linea in lineas)
            {
                string[] campos = linea.Split(':');

                string producto = campos[0];
                int cantidad = int.Parse(campos[1]);

                total = total + cantidad; //calcula total de unidades vendidas

                if (cantidad > mayorCantidad) //identifica producto mas vendido
                {
                    mayorCantidad = cantidad;
                    productoMasVendido = producto;
                }
            }

            Console.WriteLine("Total de unidades vendidas: " + total);

            Console.WriteLine(
                "Producto más vendido: " + productoMasVendido
            );

            Console.WriteLine(
                "Cantidad vendida: " + mayorCantidad
            );
        }
        else
        {
            Console.WriteLine("El archivo no existe.");
        }
    }
}
