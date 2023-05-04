using System;

namespace Actividad100NumerosFor
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            char respuesta;
            int cont = 0;
            int num, suma = 0;
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Ingrese un número: ");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num);
                suma = num + suma;
            }
            Console.WriteLine(suma);
            Console.ReadLine();


            do
            {
                Console.WriteLine("Ingrese una estatura");
                double est = Convert.ToDouble(Console.ReadLine());
                sum = sum + est;//acumulador
                cont++;//contador cont = cont + 1

                repetir:
                Console.WriteLine("Desea ingresar otra nota? s = sí, n = no");
                respuesta = Convert.ToChar(Console.ReadLine());
                if (respuesta != 's' && respuesta != 'n')
                { 
                    goto repetir;
                }
            } while (respuesta == 's');
            double promedio = sum / cont;
            Console.WriteLine("El promedio es " + promedio);
        }
    }
}
