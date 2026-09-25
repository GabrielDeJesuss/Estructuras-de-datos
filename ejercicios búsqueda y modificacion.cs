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

                        //Busqueda y modificacion de vectores
            //busqueda lineal, verificación de existencia y actualizacion de un elemento en un array

            int[] codigos = new int[20];
            Console.WriteLine("Ingrese 20 codigos numericos a continuación");
            for (int i = 0; i < codigos.Length; i++)
            {
                Console.WriteLine($"Codigo No. {i +1}");
                codigos[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"\nCodigos actuales: {string.Join(", ", codigos)}");
            Console.WriteLine($"\nIngrese el codigo que desea actualizar: ");
            int busqueda = Convert.ToInt32(Console.ReadLine());

            int indiceEncontrado = -1;
            //'for' si se conoce la cantidad de iteraciones; 'while' si no se conoce
            for (int i = 0; i < codigos.Length; i++)
            {
                if (codigos[i] == busqueda) 
                //23 == 23 -> T
                //25 == 23 -> F
                {
                    indiceEncontrado = i;
                    break;
                }
            }

            //validando si encontré el valor que quiero modificar
            if (indiceEncontrado != -1)
            {
                Console.WriteLine("Ingrese el nuevo codigo: ");
                codigos[indiceEncontrado] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"\nVector actualizado: {string.Join(", ", codigos)}");
                Console.WriteLine($"\nValor del indice: { indiceEncontrado }");
            }else {
                Console.WriteLine("\nError: El codigo ingresado no existe en la base de datos");
            }
        }
    }
}
