using System;

namespace ActividadSupermercadito
{
    class Program
    {
        static void Main(string[] args)
        {
            int producto, cantidad, total = 0, contador = 0;
            //Daniel Ruano 1247723
            //Angel Pérez 1135323
            //Daniel Castro 1276423
            while (true)
            {
                Console.Write("Ingrese el valor del producto (-1 para salir): ");
                producto = int.Parse(Console.ReadLine());

                if (producto == -1)
                {
                    break;
                }

                Console.Write("Ingrese la cantidad de productos: ");
                cantidad = int.Parse(Console.ReadLine());

                total += producto * cantidad;
                contador += cantidad;
            }

            Console.WriteLine("\nTotal a pagar: $" + total);
            Console.WriteLine("Cantidad de productos: " + contador);

            Console.ReadKey();
        }
    }
}
