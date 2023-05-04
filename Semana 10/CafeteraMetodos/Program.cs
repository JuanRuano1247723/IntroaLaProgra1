using System;

namespace CafeteraMetodos
{
    class Program
    {
        public class Cafetera{

            int codigo;
            bool lleno;
            int capacidad;
            int disponibles;
           
            public void HacerCafe()
            {
                lleno = true;
                disponibles = capacidad;
            }
            public void ServirTaza(int cantidad)
            {
                if (disponibles >= cantidad)
                {
                    disponibles -= cantidad;
                }
                else
                {
                    Console.WriteLine("No tenemos suficientes tazas disponibles");
                }
            }

            public double ObtenerPocentaje()
            {
                double porcentaje = ((double)disponibles / capacidad)*100;
                return porcentaje;
            }
            public void MostrarEstados()
            {
                string texto = codigo + "capcidad:"+" tazas servidas: "+(capacidad-disponibles)+" porcentaje: "+ObtenerPocentaje()+"%";
                Console.WriteLine(texto);
            }
            public Cafetera(int elcodigo, int elcapacidad)//no es un error tan solo me gusta "elcapacidad" 
            {
                codigo = elcodigo;
                capacidad = elcapacidad;
                lleno = false;
                disponibles = 0;
            }
            public static void Main()
            {
            inicio:
                Console.Clear();
                try
                {                    
                    Console.WriteLine("¿Ingrese capacidad de cafetera?");
                    int cap = Convert.ToInt32(Console.ReadLine());
                    string opcion = "";
                    Cafetera cafe = new Cafetera(1, cap);
                    cafe.HacerCafe();
                do
                {
                    Console.WriteLine("¿Cuantas tazas quiere servir?");
                    int tz = Convert.ToInt32(Console.ReadLine());
                    cafe.ServirTaza(tz);
                    cafe.MostrarEstados();

                    Console.WriteLine("¿Desea ingresar más tazas?");
                    opcion = Console.ReadLine().ToLower();
                } while (opcion == "s");
                }
                catch  
                {
                   goto inicio;
                }
            }
        }

      
    }
}
