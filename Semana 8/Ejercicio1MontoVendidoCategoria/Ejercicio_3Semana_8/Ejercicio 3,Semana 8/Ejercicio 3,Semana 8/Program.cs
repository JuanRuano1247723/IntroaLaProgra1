using System;

namespace Ejercicio_3_Semana_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBilletes1000, numBilletes500, numBilletes200, numBilletes100, numBilletes50, numBilletes20, numMonedas10, numMonedas5, numMonedas1;
            double totalCaja;

            Console.Write("Ingrese el número de billetes de $1000: ");
            numBilletes1000 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de billetes de $500: ");
            numBilletes500 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de billetes de $200: ");
            numBilletes200 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de billetes de $100: ");
            numBilletes100 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de billetes de $50: ");
            numBilletes50 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de billetes de $20: ");
            numBilletes20 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de monedas de $10: ");
            numMonedas10 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de monedas de $5: ");
            numMonedas5 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de monedas de $1: ");
            numMonedas1 = int.Parse(Console.ReadLine());

            totalCaja = (numBilletes1000 * 1000) + (numBilletes500 * 500) + (numBilletes200 * 200) + (numBilletes100 * 100) + (numBilletes50 * 50) + (numBilletes20 * 20) + (numMonedas10 * 10) + (numMonedas5 * 5) + numMonedas1;

            Console.WriteLine("El total de la caja registradora es de: $" + totalCaja);
        }
    }
}

