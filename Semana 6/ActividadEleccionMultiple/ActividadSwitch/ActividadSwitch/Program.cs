using System;

namespace ActividadSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese día: ");
            String dia = Console.ReadLine();

            Console.WriteLine("Ingrese edad ");
            int edad = Convert.ToInt32(Console.ReadLine());

            if (edad > 0)
            {
                if (edad >= 18)
                {
                    Console.WriteLine("Es mayor de edad");
                }
                else
                {
                    Console.WriteLine("Es menor de edad");
                }
            }
            else
            {
                Console.WriteLine("Edad Invalida");
            }


//edad
            if (edad >= 0 && edad <= 12)
            {
                Console.WriteLine("Nin@");
            }
            else if (edad >= 13 && edad <= 17)
            {
                Console.WriteLine("Adolescente");
            }
            else if (edad >= 18 && edad <= 30)
            {
                Console.WriteLine("Adult@");
            }
            else if (edad >= 31 && edad <= 50)
            {
                Console.WriteLine("Mediana Edad");
            }
            else if (edad > 50)
            {
                Console.WriteLine("Tercera Edad");
            }

//edad optimimizado
            if (edad > 50)
            {
                Console.WriteLine("Tercera Edad");
            }
            else if (edad >= 31)
            {
                Console.WriteLine("Mediana Edad");
            }
            else if (edad >= 18)
            {
                Console.WriteLine("Adult@");
            }
            else if (edad >= 13)
            {
                Console.WriteLine("Adolescente");
            }
            else if (edad >= 0)
            {
                Console.WriteLine("Nin@");
            }
            //ejercicio

            Console.WriteLine("Ingrese un numero: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int letra = num % 23;

            switch (letra)
            {
                case 0:
                    Console.WriteLine(" T ");
                    break;

                case 1:
                    Console.WriteLine(" R ");
                    break;

                case 2:
                    Console.WriteLine(" W ");
                    break;

                case 3:
                    Console.WriteLine(" A ");
                    break;
                case 4:
                    Console.WriteLine(" G ");
                    break;
                case 5:
                    Console.WriteLine(" M ");
                    break;
                case 6:
                    Console.WriteLine(" Y ");
                    break;
                case 7:
                    Console.WriteLine(" F ");
                    break;
                case 8:
                    Console.WriteLine(" P ");
                    break;
                case 9:
                    Console.WriteLine(" D ");
                    break;
                case 10:
                    Console.WriteLine(" X ");
                    break;
                case 11:
                    Console.WriteLine(" B ");
                    break;
                case 12:
                    Console.WriteLine(" N ");
                    break;
                case 13:
                    Console.WriteLine(" J ");
                    break;
                case 14:
                    Console.WriteLine(" Z ");
                    break;
                case 15:
                    Console.WriteLine(" S ");
                    break;
                case 16:
                    Console.WriteLine(" Q ");
                    break;
                case 17:
                    Console.WriteLine(" V ");
                    break;
                case 18:
                    Console.WriteLine(" H ");
                    break;
                case 19:
                    Console.WriteLine(" L ");
                    break;
                case 20:
                    Console.WriteLine(" C ");
                    break;
                case 21:
                    Console.WriteLine(" K ");
                    break;
                case 22:
                    Console.WriteLine(" E ");
                    break;
                case 23:
                    Console.WriteLine(" T ");
                    break;
                default:
                    Console.WriteLine($"no válida");
                    break;
            }
        }

    }
}
         