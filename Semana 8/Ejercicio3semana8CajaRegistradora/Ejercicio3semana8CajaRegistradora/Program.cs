using System;

namespace Ejercicio3semana8CajaRegistradora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Daniel Ruano 1247723
            //Angel Pérez 1135323
            int numBilletes200 = 0,
                     numBilletes100 = 0,
                     numBilletes50 = 0,
                     numBilletes20 = 0,
                     numBilletes10 = 0,
                     numBilletes5 = 0,
                     numMonedas1 = 0,
                     numMonedas50c = 0,
                     numMonedas25c = 0,
                     numMonedas10c = 0, 
                     numMonedas5c = 0;
            double totalCaja;

        inicio:
            Console.Clear();
            Console.WriteLine("Ingrese la cantidad de la caja: ");
            bool ni = double.TryParse(Console.ReadLine(), out  totalCaja);
            if (ni == true && totalCaja >= 0)
            {
                do
                {
                    if (totalCaja % 200 == 0)
                    {
                        numBilletes200++;
                        totalCaja -= 200;
                    } else if (totalCaja % 100 == 0)
                    {
                        numBilletes100++;
                        totalCaja -= 100;
                    }
                    else if (totalCaja % 50 == 0)
                    {
                        numBilletes50++;
                        totalCaja -= 50;
                    }
                    else if (totalCaja % 20 == 0)
                    {
                        numBilletes20++;
                        totalCaja -= 20;
                    }
                    else if (totalCaja % 10 == 0)
                    {
                        numBilletes10++;
                        totalCaja -= 10;
                    }
                    else if (totalCaja % 5 == 0)
                    {
                        numBilletes5++;
                        totalCaja -= 5;
                    }
                    else if (totalCaja % 1 == 0)
                    {
                        numMonedas1++;
                        totalCaja -= 1;
                    }
                    else if (totalCaja % 0.50 == 0)
                    {
                        numMonedas50c++;
                        totalCaja -= 0.50;
                    }
                    else if (totalCaja % 0.25 == 0)
                    {
                        numMonedas25c++;
                        totalCaja -= 0.25;
                    }
                    else if (totalCaja % 0.10 == 0)
                    {
                        numMonedas10c++;
                        totalCaja -= 0.10;
                    }
                    else if (totalCaja % 0.5 == 0)
                    {
                        numMonedas5c++;
                        totalCaja -= 0.5;
                    }


                } while (totalCaja != 0);

                if (numBilletes200 != 0) {
                    Console.WriteLine("hay " + numBilletes200 + " de billetes de Q200: ");
                }
                if (numBilletes100 != 0)
                {
                    Console.WriteLine("hay " + numBilletes100 + " de billetes de Q100: ");
                }
                if (numBilletes50 != 0)
                {
                    Console.WriteLine("hay " + numBilletes50 + " de billetes de Q50: ");
                }
                if (numBilletes20 != 0)
                {
                    Console.WriteLine("hay " + numBilletes20 + " de billetes de Q20: ");
                }
                if (numBilletes10 != 0)
                {
                    Console.WriteLine("hay " + numBilletes10 + " de billetes de Q10: ");
                }
                if (numBilletes5 != 0) { 
                    Console.WriteLine("hay " + numBilletes5 + " de billetes de Q5: ");
                }
                if (numMonedas1 != 0)
                {
                    Console.WriteLine("hay " + numMonedas1 + " de Monedas de Q1: ");
                }
                if (numMonedas50c != 0)
                {
                    Console.WriteLine("hay " + numMonedas50c + " de Monedas de 50c: ");
                }
                if (numMonedas25c != 0)
                {
                    Console.WriteLine("hay " + numMonedas25c + " de Monedas de 25c: ");
                }
                if (numMonedas10c != 0)
                {
                    Console.WriteLine("hay " + numMonedas10c + " de Monedas de 10c: ");
                }
                if (numMonedas5c != 0)
                {
                    Console.WriteLine("hay " + numMonedas5c + " de Monedas de 5c: ");
                }
            }
            else
            {
                goto inicio;
            }

        }
    }
}
