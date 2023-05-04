using System;

namespace ConsoleApp1
{
    class Program
    {//fin
        static void Main(string[] args)
        {
            int x = 10;
            double y = 25;
            double z = x + y;

            int w = 4;
            double a = y / w; //redondea
            double b = y / w; //redondea
            double c = y % w;

            Console.WriteLine("Suma: " + z);
            Console.WriteLine("Division a: " + a);
            Console.WriteLine("Division b: " + b);
            Console.WriteLine("Modulo c:  " + c);

            Console.ReadKey();

        }
    }//fin
}
