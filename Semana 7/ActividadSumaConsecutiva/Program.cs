using System;

namespace ActividadSumaConsecutiva
{
    class Program
    {
        static void Main(string[] args)
        {
            //Daniel Ruano 1247723
            //Angel Pérez 1135323
            //Daniel Castro 1276423
            int valor;
            Console.Write("Ingrese un valor positivo: ");
            while (!int.TryParse(Console.ReadLine(), out valor) || valor <= 0)
            {
                Console.WriteLine("El valor ingresado no es válido. Ingrese un valor positivo: ");
            }
            for (int i = 1; i <= valor; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
