using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciotienda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Una tienda registra ñas ventas de 10 dias en un array double[]
            //calcular
            //1.calcular total vendido
            //2.promedio diario
            //3.encontrar día con mayor venta
            //4.día con menor venta
            //5.contar cuantos días superaron al promedio

            double[] ventas = {200.000, 302.000, 400.000, 300.233, 740.452, 100.244, 99.423, 823.231, 902.211};
            double total = 0;
            double mayorVenta = ventas[0];
            double menorVenta = ventas[0];
            int diaMayorVenta = 0;
            int diaMenorVenta = 0;

            for (int i = 0; i < ventas.Length; i++) {
                total += ventas [i];

                //i = 0
                //ventas[i] = 200.000
                //total = 200.000

                //i = 1
                //ventas[i] = 302.000
                //total = 502.000

                if (ventas[i] > mayorVenta)
                {
                    mayorVenta += ventas[i];
                    diaMayorVenta = i;
                }
                if (ventas [i] > menorVenta)
                {
                    menorVenta = ventas [i];
                    diaMenorVenta = i;
                }
            }

            double promedio = total / ventas.Length;
            int diasSobrePromedio = 0;

            for (int i = 0; i < ventas.Length; i++)
            {
                if (ventas[i] > promedio)
                {
                    diasSobrePromedio++;
                }
            }

            Console.WriteLine("REPORTE DE VENTAS");
            Console.WriteLine();

            Console.WriteLine($"Total vendido: ${total:F3}");
            Console.WriteLine($"Promedio diario: ${promedio:F3}");
            Console.WriteLine();

            Console.WriteLine($"Mayor venta: ${mayorVenta:F3} - el día {diaMayorVenta + 1}");
            Console.WriteLine($"Menor venta: ${menorVenta:F3} - el día {diaMenorVenta + 1}");

            Console.WriteLine($"Días que superaro el promedio de ventas: {diasSobrePromedio}");
            Console.WriteLine();

            Console.WriteLine("Ventas por dias");
            for (int i = 0; i < ventas.Length; i++)
            {
                Console.WriteLine($"Día {i + 1}: ${ventas[i]:F3}");
            }
        }
    }
}
