using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase210822
{
    internal class Program
    {
        //funciones: reciben parametros y devuelven un valor
        static double CalcularAreaCirculo(double radio)
        {
            const double PI = 3.141592;
            //ahora voy a realizar el calculo con la formula
            double area = PI * Math.Pow(radio, 2); // double area = PI * (radio**2)

            return area;
        }
        static void Main(string[] args)
        {
            Console.Write("Ingrese el radio del círculo: ");
            double r = Convert.ToDouble(Console.ReadLine());

            double result = CalcularAreaCirculo(r);
            Console.WriteLine($"El área es: {result:F2} m2");
        }
    }
}
