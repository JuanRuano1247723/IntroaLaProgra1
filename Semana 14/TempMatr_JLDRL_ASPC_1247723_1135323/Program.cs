using System;

namespace TempMatr_JLDRL_ASPC_1247723_1135323
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Se le ha solicitado guardar la temperatura de la mañana y tarde  los últimos 7 días (llenar la matriz con Random),  y mostrar :

            -   las temperaturas en una forma entendible.
            -   promedio de temperatura de los últimos 3 días, de la mañana
            -   día mas caluroso por la tarde indicar que dia de la semana es, por ejemplo. Lunes, Martes, Miercoles, etc.
            -   día menos caluroso  por la mañana
            -   cuantos días tienen temperatura menor a 30 grados por la mañana y por la tarde.
            -   indicar si es una temporada calurosa, para ello el promedio de la temperatura debe ser mayor a
                30 grados en la tarde.
             */
            int[,] temperatura = new int[7, 2];
            string[] mantar = { "Mañana", "Tarde" };
            string[] semana = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
            for (int f = 0; f < semana.Length; f++)
            {
                for (int c = 0; c < 2; c++)
                {
                    Random ra = new Random();
                    temperatura[f, c] = ra.Next(-5, 50);
                }
            }
            for (int f = 0; f < semana.Length; f++)
            {
                Console.WriteLine(semana[f] + " ");
                for (int c = 0; c < 2; c++)
                {
                    Console.WriteLine($"{temperatura[f, c]}°C -- {mantar[c]}"); ;
                }
                Console.WriteLine();
            }

            double[] promediotemp3 = new double[3];
            double promedio = 0;
            for (int f = 4, i = 0; f < 7 && i < 3; f++, i++)
            {
                promedio += temperatura[f, 0];
                
            }
            promedio /= 3;
                Console.WriteLine($" Promedio {Math.Round(promedio,2)}");
                Console.WriteLine();

            int mayor = 0;
            string dia="";
            for (int i = 0; i < 7; i++)
            {
                if (mayor < temperatura[i,1]) {
                    mayor = temperatura[i, 1];
                    dia = semana[i];
                }
            }
            Console.WriteLine($"El día más caluroso de la semana por la tarde es {dia} con {mayor}°C");
            Console.WriteLine();

            int menor = 0;
            for (int i = 0; i < 7; i++)
            {
                if (menor > temperatura[i, 0])
                {
                    menor = temperatura[i, 0];
                    dia = semana[i];
                }
            }
            Console.WriteLine($"El día menos caluroso de la semana por la mañana es {dia} con {menor}°C");
            Console.WriteLine();

            int menostrienta = 0;
            for (int f = 0; f < semana.Length; f++)
            {
                    if (temperatura[f, 0] < 30 && temperatura[f, 1] < 30)
                    {
                        menostrienta++;
                    }
            }
            Console.WriteLine($"Hubo {menostrienta} días con temperatura menor a 30°C");

            double[] promedioest = new double[5];
            for (int f = 4; f < 7; f++)
            {
                promedio += temperatura[f, 1];

            }
            promedio /= 7;
            if (promedio >= 30)
            {
                Console.WriteLine("Es una temporada calurosa");
            }
            else
            {
                Console.WriteLine("No es una temporada calurosa");
            }

            Console.WriteLine();
        }

    }
}
