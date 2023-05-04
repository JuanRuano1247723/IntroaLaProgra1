using System;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            i++; //i = i + 1

            Console.WriteLine("i " + i);
            int val = 10 / ++i; // 10 /3
            Console.WriteLine("val: " + val);
            Console.WriteLine("i v3: " + i);

            // operadores lógicos
            bool res = 3 < 6;
            Console.WriteLine("Res: " + res);
            int nota = 90;
            bool res2 = nota > 90 && nota < 100;
            Console.WriteLine("Res2: " + res2);

            String nombre;
            int edad;

            Console.WriteLine("Ingrese su nombre ");
            nombre = Console.ReadLine();
            // si el nombre viene vacio, muestra error, sino da la bienvenida
            if (nombre == "")
            {
                Console.WriteLine("No ingreso un nombre valido");

            }
            else
            {
                Console.WriteLine("Bienvenid@ " + nombre);
            }

        }
    }
}
