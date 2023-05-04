using System;

namespace PromediodeResultadosConCiclos
{
    class Program
    {
        static void Main(string[] args)
        {
            //entrada de datos
            double nota = 0;
            double promedio = 0, suma = 0;
            char respuesta;
            int cont = 0;

            do
            {
                Console.WriteLine("Ingrese nota");
                nota = Convert.ToInt32(Console.ReadLine());
                suma = suma + nota;//acumulador
                cont++;//contador cont = cont + 1

                Console.WriteLine("Desea ingresar otra nota? s = sí, n = no");
                respuesta = Convert.ToChar(Console.ReadLine());
            } while (respuesta == 's');
            promedio = suma / cont;
            Console.WriteLine("El promedio es " + promedio);

            Console.ReadKey();
            //while
            int i = 0;
            while (i < 10)
            {
                i++;
                Console.WriteLine(i);
            }

            Console.ReadKey();
            //for
            for (int j = 0; j <= 10; j++)
            {
                Console.WriteLine(j);
            }

            int num;
            Console.WriteLine("Ingrese número a evaluar: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Multiplos: ");
            for (int h = 1; h <= 100; h++)
            {
                if (h % num == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
