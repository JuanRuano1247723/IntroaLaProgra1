using System;

namespace RETO_JLDRL_1247723_LIBRO
{
    class Program
    {
        public class Libro
        {
            string codigo;
            string nombre;
            int leidas;
            int cantpaginas;
            bool terminado = false;

            public bool Leer(int aleer)
            {
                leidas =+ aleer;
                if (leidas > cantpaginas)
                {
                   Console.WriteLine("No hay más páginas para leer we");
                   Console.ReadLine();
                   leidas =- aleer;
                }
                else if (leidas == cantpaginas)
                { 
                    terminado = true;
                }
                else
                {
                    terminado = false;
                }
                return terminado;
            }

            public double ObtenerPocentaje()
            {
                double porcentaje = ((double)leidas / cantpaginas) * 100;
                return porcentaje;
            }
            public void ObtenerPaginaActual()
            {
                Console.WriteLine($"Vas por la página {leidas} we");
            }
            public void MostrarLibro()
            {
                string texto = $"El libro: {codigo} '{nombre}' posee {cantpaginas} de páginas de las cual se han leído {leidas}\n lo cuál significa que se ha completado en un {ObtenerPocentaje()}% ";
                Console.WriteLine(texto);
            }
            public void EstadodelLibro()
            {
                if (terminado == true)
                {
                    Console.WriteLine("Libro completado");
                }
                else if (terminado == false && leidas>0)
                {
                    Console.WriteLine("Libro en proceso");
                }
                else
                {
                    Console.WriteLine("Libro no leído");
                }
            }
            public Libro(string elcodigo, int lacantidaddepag, string elnombre)
            {
                codigo = elcodigo;
                cantpaginas = lacantidaddepag;
                nombre = elnombre;
            }
        }
        public static void Main()
        {
        inicio:
            Console.Clear();
            try
            {
                Console.WriteLine("¿Ingrese la cantidad de páginas que posee el libro?");
                int cant = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("¿Ingrese el nombre del libro?");
                string nom = Console.ReadLine();
                Libro libro = new Libro("184563", cant,nom);
                libro.EstadodelLibro();
                char opcion;
                do
                {
                    Console.WriteLine("¿Cuantas páginas quiere leer?");
                    int aleer = Convert.ToInt32(Console.ReadLine());

                    libro.Leer(aleer);
                    libro.MostrarLibro();
                    libro.EstadodelLibro();

                    Console.WriteLine("¿Desea leer más páginas?");
                    opcion = Convert.ToChar(Console.ReadLine().ToLower());
                } while (opcion == 's');
            }
            catch
            {
                goto inicio;
            }
        }
    }
}
