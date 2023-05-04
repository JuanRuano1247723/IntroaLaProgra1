using System;

namespace TAREA_PELICULA
{
    class Program
    {
        class Pelicula
        {
            float duracionhora;
            string nombre;
            bool epica, similar;
            string genero;
            int anio;
            string calificacion;
            public Pelicula(float laduracion, string elnombre, int elanio)
            {
                duracionhora = laduracion;
                nombre = elnombre;
                genero = "";
                anio = elanio;
                epica = false;
                similar = false;
            }
            public string PeliculaGenero(int quees)
            {
                if (quees == 0)
                {
                    genero = "Acción";
                }
                else if (quees == 1)
                {
                    genero = "Comedia";
                }
                else if (quees == 2)
                {
                    genero = "Drama";
                }
                else if(quees == 3)
                {
                    genero = "Suspenso";
                }
                return genero;
            }
            public bool EsPeliculaEpica()
            {
                if (duracionhora >= 3)
                {
                    epica = true;
                }
                else
                {
                    epica = false;
                }
                return epica;
            }
            public void Calificiacion(float rate)
            {
                if (rate >= 0 || rate<=2)
                {
                    calificacion = "muy mala";
                }
                else if (rate > 2 || rate <= 5)
                {
                    calificacion = "mala";
                }
                else if (rate > 5 || rate <= 7)
                {
                    calificacion = "regular";
                }
                else if (rate > 7 || rate <= 8)
                {
                    calificacion = "buena";
                }
                else if (rate > 8 || rate <= 10)
                {
                    calificacion = "excelente";
                }
            }

            public bool esSimilar(Pelicula peli1, Pelicula peli2)
            {
                if (peli1.genero == peli2.genero)
                {
                    similar = true;
                }
                else
                {
                    similar = false;
                }
                return similar;
            }
            public void MostrarInfo()
            {
                string texto = "";
                if (epica == true)
                {
                    texto = $"nombre:{nombre} duración: {duracionhora} horas, género: {genero} y es Epica y año: {anio}\nCalificación: {calificacion}";
                    Console.WriteLine(texto);
                }
                else
                {
                    texto = $"nombre:{nombre} duración: {duracionhora} horas, género: {genero} y año: {anio}\nCalificación: {calificacion}";
                    Console.WriteLine(texto);
                }
                
                Console.WriteLine(texto);
            }
        }
        static void Main()
        {
        inicio:
            Console.Clear();
            try
            {
                Console.WriteLine("¿Ingrese el nombre de la pelicula?");
                string nom = Console.ReadLine();
                Console.WriteLine("¿Ingrese la duración de la pelicula?");
                float dur = (float) Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("¿Ingrese el a año de lanzamiento");
                int cant = Convert.ToInt32(Console.ReadLine());
                Pelicula pelicula = new Pelicula(dur,nom,cant);
                Console.WriteLine("¿Qué genero es(0-3)?");
                int es = Convert.ToInt32(Console.ReadLine());
                pelicula.PeliculaGenero(es);
                Console.WriteLine("¿Califique la pelicula?");
                float rate = (float)Convert.ToDouble(Console.ReadLine());
                pelicula.Calificiacion(rate);
                pelicula.MostrarInfo();

                Console.WriteLine("¿Son SIMILARES?");
                Console.WriteLine("¿Ingrese el nombre de la otra pelicula?");
                string nom2 = Console.ReadLine();
                Console.WriteLine("¿Ingrese la duración de la otra pelicula?");
                float dur2 = (float)Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("¿Ingrese el a año de lanzamiento la otra pelicula");
                int cant2 = Convert.ToInt32(Console.ReadLine()); 
                Pelicula pelicula2 = new Pelicula(dur2, nom2, cant2);
                Console.WriteLine("¿Qué genero es(0-3) de la otra pelicula?");
                int es2 = Convert.ToInt32(Console.ReadLine());
                pelicula2.PeliculaGenero(es2);
                Console.WriteLine("¿Califique la otra pelicula?");
                float rate2 = (float)Convert.ToDouble(Console.ReadLine());
                pelicula2.Calificiacion(rate2);
                pelicula2.MostrarInfo();
               

                if (pelicula.esSimilar(pelicula, pelicula2))
                {
                    Console.WriteLine("Son similares");
                }
                else
                {
                    Console.WriteLine("No son similares");
                }
            }
            catch
            {
                goto inicio;
            }
        }
    }
}
