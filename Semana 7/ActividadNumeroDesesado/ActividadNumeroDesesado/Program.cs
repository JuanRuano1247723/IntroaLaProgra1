using System;

namespace ActividadNumeroDesesado
{
    class Program
    {
        static void Main(string[] args)
        {
            //Daniel Ruano 1247723
            //Angel Pérez 1135323
            //Daniel Castro 1276423
            String n = "";
            int suma = 0;

            while(n != "n")
            {
                Console.WriteLine("Ingrese un número");
                int.TryParse(Console.ReadLine(), out int num);
                suma += num;
                Console.ReadKey();
                Console.WriteLine("Desea continuar (escrbiba n para parar y obtener la suma)");
                n = Console.ReadLine();
            }
            Console.WriteLine("la suma es: "+suma);
        }
    }
}
