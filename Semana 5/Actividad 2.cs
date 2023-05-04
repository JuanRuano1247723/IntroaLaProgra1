using System;

namespace ActividadAreaCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Double pi = Math.PI;
            double r = 5.77;
            double circulo = pi * Math.Pow(r, 2);

            Console.WriteLine("La constante π es apróximadamente: " + Math.Round(pi, 4));
            Console.WriteLine("El radio de la circuferencia es: " + r);

            Console.WriteLine("El área de la circuferencia es: " + circulo);


            Console.ReadKey();
            
        }
    }
}
