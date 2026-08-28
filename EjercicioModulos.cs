using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjericioModulos
{
    internal class Program
    {
        //procedimiento sumar e imprimir
        public static void ImprimirSuma(int a, int b) { //a, b son los parametros
            int suma = a + b;
            Console.WriteLine (suma);
        }

        public static void MostrarPotenciaX(double num1, double potencia) 
        {
            double result = Math.Pow(num1, potencia);
            Console.WriteLine ($"La potencia de {num1} elevado a {potencia} es: {result}");
        }
         static void ModificarValor(int n)
        {
            n = n + 1;
            Console.WriteLine($"Dentro del Metodo: {n}");
        }
        
        static void Main(string[] args)
        {
            int x = 12, y = 3;

            ImprimirSuma(y, x); //y, x (Argumenos actuales)
            ImprimirSuma(1000, -1); //1000, -1 (Argumentos literales)
            MostrarPotenciaX(x, y);
            
            int edad = 23;
            Console.WriteLine($"Antes del Metodo: {edad}");
            ModificarValor (edad);
            Console.WriteLine($"Despues del Metodo: {edad}");
        }
    }
}
