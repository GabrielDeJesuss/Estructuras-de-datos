namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ejercicio 1
            
            double[] temperaturas = new double[5];

            Console.WriteLine("---- Ingreso de temperaturas ----");

            for (int i = 0; i < temperaturas.Length; i++)
            {
                Console.WriteLine($"Ingrese la temperatura del día {i + 1}: ");
                temperaturas[i] = Convert.ToDouble(Console.ReadLine());
            }

            double suma = 0;
            double maxT = temperaturas[0];
            double minT = temperaturas[0];

            foreach (double t in temperaturas) 
            {
                suma += t;
                if (t > maxT) maxT = t;
                if (t < minT) minT = t;
            }

            double promedio = suma / temperaturas.Length;

            //Salida
            Console.WriteLine("\n---Reporte---");
            Console.WriteLine($"Temperaturas registradas: {string.Join(", ",temperaturas)}");
            Console.WriteLine($"Temperatura promedio: {promedio:F2}°C");
            Console.WriteLine($"Temperatura maxima: {maxT}°C");
            Console.WriteLine($"Temperatura minima: {minT}°C");
        }
    }
}
