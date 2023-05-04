using System;

namespace Ejercicio1MontoVendidoCategoria
{
    class Program
    {
        static void Main(string[] args)
        {
            // Angel Pérez
            // Daniel Ruano
            // Daniel Castro
            double mayor1300 = 0;
            double mayor300menorIgual1300 = 0;
            double menorIgual300 = 0;
            double montoMayor1300 = 0;
            double montoMayor300menorIgual1300 = 0;
            double montoMenorIgual300 = 0;
            double montoTotal = 0;
        inicio:
            Console.Clear();
            Console.Write("Ingrese la cantidad de ventas realizadas por el empleado durante el día: ");
            bool n = int.TryParse(Console.ReadLine(), out int venta);
            Console.WriteLine();
            if (n == true && venta > 0)
            {

                for (int i = 1; i <= venta; i++)
                {
                    Console.Write(i+". "+"Ingrese el monto de la venta: ");
                    bool ni = double.TryParse(Console.ReadLine(), out double monto);
 
                    if (ni == true &&  monto >= 0)
                    {
                        montoTotal += monto;

                        if (monto > 1300)
                        {
                            mayor1300++;
                            montoMayor1300 += monto;
                        }
                        else if (monto > 300)
                        {
                            mayor300menorIgual1300++;
                            montoMayor300menorIgual1300 += monto;
                        }
                        else
                        {
                            menorIgual300++;
                            montoMenorIgual300 += monto;
                        }
                    }
                    else
                    {
                        i--;
                    } 
                }

                Console.WriteLine("Cantidad de ventas mayores a Q1300:" + mayor1300);
                Console.WriteLine("Cantidad de ventas mayores a Q300 pero menores o iguales a Q1300: " + mayor300menorIgual1300);
                Console.WriteLine("Cantidad de ventas menores o iguales a Q300: " + menorIgual300);

                Console.WriteLine("Monto de las ventas mayores a Q1300: " + montoMayor1300);
                Console.WriteLine("Monto de las ventas mayores a Q300 pero menores o iguales a Q1300: " + montoMayor300menorIgual1300);
                Console.WriteLine("Monto de las ventas menores o iguales a Q300: " + montoMenorIgual300);

                Console.WriteLine("Monto total de las ventas: " + montoTotal);
            }
            else
            {
                goto inicio;
            }
        }
    }
}
