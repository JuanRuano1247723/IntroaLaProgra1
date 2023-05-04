using System;

namespace Matrices_JLDRL_1247723
{
    class Program
    {
        static void Main()
        {
            double[,] notasss = new double[5, 6];
            string[] nombres = new string[5];// nombres de estudiantes
            string[] nombresmat = 
    {"Matemáticas", "Física", "Química", "Historia", "Inglés", "Educación Física"};
            //llenar
            for (int f = 0; f < nombres.Length; f++)
            {
                Console.WriteLine("Ingrese el nombre del estudiante");
                nombres[f] = Console.ReadLine();
                for (int c = 0; c < 6; c++)
                {
                    Random ra = new Random();
                    notasss[f, c] = ra.Next(1, 100);
                }
            }// mostrar datos
            for (int f = 0; f < 5; f++)
            {
                Console.WriteLine(nombres[f] + " ");
                for (int c = 0; c < 6; c++)
                {
                    Console.WriteLine($"{notasss[f, c]} -- {nombresmat[c]}");
                }
                Console.WriteLine();
            }

            //promedio por estudiante
            double[] promedioest = new double[5];
            for (int f = 0; f < 5; f++)
            {
                double promedio = 0;
                for (int c = 0; c < 4; c++)
                {
                    promedio += notasss[f, c];
                }
                promedio /= 6;
                promedioest[f] = promedio;
            }
            //mostrar datos
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(nombres[i] + " ");
                for (int c = 0; c < 6; c++)
                {
                    Console.WriteLine(notasss[i, c] + " - "+nombresmat[c]);
                }
                Console.WriteLine($" Promedio {promedioest[i]}");
                Console.WriteLine();
            }
        }
    }
}
