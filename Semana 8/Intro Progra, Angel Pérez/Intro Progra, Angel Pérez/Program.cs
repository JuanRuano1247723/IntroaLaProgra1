using System;

namespace Intro_Progra__Angel_Pérez
{
    class Program
    {
        static void Main(string[] args)
        {
        //Daniel Ruano 1247723
        //Angel Pérez 1135323
        inicio:
            Console.Clear();
            Console.Write("Ingrese el número de empleados: ");
            bool ni = int.TryParse(Console.ReadLine(), out int numEmpleados);
            if (ni == true && numEmpleados >= 0)
            {
                double pagoTotal = 0;

                for (int i = 1; i <= numEmpleados; i++)
                {
                    Console.WriteLine("Empleado #" + i);
                    Console.Write("Ingrese el número de días trabajados: ");
                    int numDias = int.Parse(Console.ReadLine());

                    double horasSemana = 0;

                    for (int j = 1; j <= numDias; j++)
                    {
                        Console.Write("Ingrese las horas trabajadas en el día " + j + ": ");
                        double horasDia = double.Parse(Console.ReadLine());

                        horasSemana += horasDia;
                    }

                    Console.Write("Ingrese el salario por hora del empleado: ");
                    double salarioHora = double.Parse(Console.ReadLine());

                    double sueldoSemana = horasSemana * salarioHora;

                    Console.WriteLine("El sueldo semanal del empleado #" + i + " es de: Q" + sueldoSemana);
                    pagoTotal += sueldoSemana;
                    Console.WriteLine();
                }

                Console.WriteLine("El pago total de los es" + numEmpleados + "y se pago por los empleado: Q" + pagoTotal);
            }
            else
            {
                goto inicio;
            }

        }
    }
}

