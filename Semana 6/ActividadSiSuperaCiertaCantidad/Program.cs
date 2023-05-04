using System;

namespace ActividadSiSuperaCiertaCantidad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar sueldo: ");
            string sueldo = Console.ReadLine();
            double n11 = Convert.ToDouble(sueldo.ToString());

            if (n11 >= 3000){
                Console.WriteLine("Usted debe de abonar impuestos");
                Console.WriteLine("La cantidad a abonar es: "+n11*0.05);
            }
            else
            {
                Console.WriteLine("No hay impuestos a abonar");
            }

            Console.WriteLine("Gracias por usar El Banco");
        }
    }
}
