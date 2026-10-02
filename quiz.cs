// Online C# compiler (editor) for free
// Write and run C# online using this editor.

using System;

public class Quiz {
    public static void Main(string[] args) 
    {
        //programa para organizar y clasificar notas
        //estudiantes: 19
        string[] nombres = new string[19];
        double[] notas = new double[19];
        
            Console.WriteLine("Ingrese nombres y calificaciones de los alumnos");
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"Alumno No. {i +1}");
                nombres[i] = Convert.ToString(Console.ReadLine());
                Console.WriteLine($"Calificación final");
                notas[i] = Convert.ToDouble(Console.ReadLine());
                
            }
            Console.WriteLine($"\nAlumnos registrados: {string.Join(", ", nombres)}");
            Console.WriteLine($"Notas registradas: {string.Join(",", notas)}");
    }
}
