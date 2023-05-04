using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Angel Pérez
            // Daniel Ruano
            // Daniel Castro
            double ahorroTotal = 0;

            for (int i = 1; i <= 12; i++)
            {
                Console.Write("Ingrese la cantidad ahorrada en el mes "+ i +": ");
                bool ni = double.TryParse(Console.ReadLine(), out double ahorroMes);
                if (ni == true && ahorroMes >= 0)
                {

                    ahorroTotal += ahorroMes;

                    Console.WriteLine("Lleva ahorrado en total: " + ahorroTotal);
                    Console.WriteLine($"Lleva ahorrado en el mes " + i + ": " + ahorroMes);
                }
                else
                {
                    i--;
                }
            }

            Console.WriteLine("Ha ahorrado en total durante el año: "+ahorroTotal);
        }
    }
}
