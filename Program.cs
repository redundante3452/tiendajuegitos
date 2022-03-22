using System;

namespace TiendaJuegos
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Juegos> NuevoJuego = new List<Juegos>();
            NuevoJuego.Add(new Juegos() { Nombre = "league of legend", Id = 1, Genero = "AVENTURA" });
            NuevoJuego.Add(new Juegos() { Nombre = "valorant", Id = 2, Genero = "PLATAFORMA" });
            NuevoJuego.Add(new Juegos() { Nombre = "Call of duty", Id = 3, Genero = "ACCION" });
            NuevoJuego.Add(new Juegos() { Nombre = "tetris", Id = 4, Genero = "PUZZLE" });
            bool control = false;
            while (control == false)
            {
                Console.WriteLine("BIENVENIDOS ");
                Console.WriteLine("\n Seleccione la opcion 1 para mostrar video juego");
                Console.WriteLine("\n Seleccione la opcion 2 para agregar video juego");
                Console.WriteLine("\n Seleccione la opcion 3 para eliminar video juego");
                Console.WriteLine("\n Seleccione la opcion 4 para buscar video juego");
                Console.WriteLine("\n Seleccione la opcion x para salir");
                string opcion = Console.ReadLine(); 
                Console.WriteLine(opcion);
                if (opcion == "2")
                {
                    Console.WriteLine("\n Ingrese el nombre del video juego:");
                    string NombreJuego = Console.ReadLine();
                    Console.WriteLine(opcion);
                    Console.WriteLine("\n Ingrese el id del video juego:   ");
                    string idJuego = Console.ReadLine();
                    int idJuegos = int.Parse(idJuego);
                    Console.WriteLine(opcion);
                    Console.WriteLine("\n Ingrese el genero del video juego:");
                    string GeneroJuego = Console.ReadLine();
                    Console.WriteLine(opcion);

                    NuevoJuego.Add(new Juegos() { Nombre = NombreJuego, Id = idJuegos, Genero = GeneroJuego });

                } else if (opcion == "x")
                {
                    control = true;
                }
                else if (opcion == "3")
                {
                    Console.WriteLine("\n Ingrese el nombre del video que desea eliminar:");
                    string NombreJuego = Console.ReadLine();
                    Console.WriteLine(opcion);
                    Console.WriteLine("\n Ingrese el id del video juego que desea eliminar:   ");
                    string idJuego = Console.ReadLine();
                    int idJuegos = int.Parse(idJuego);
                    Console.WriteLine(opcion);
                    Console.WriteLine("\n Ingrese el genero del video juego que desea eliminar:");
                    string GeneroJuego = Console.ReadLine();
                    Console.WriteLine(opcion);
                    NuevoJuego.Remove(new Juegos() { Nombre = NombreJuego, Id = idJuegos, Genero = GeneroJuego });
                }
                else if (opcion == "1")
                {
                    for (int i = 0; i < NuevoJuego.Count; i++)
                    {
                        Console.WriteLine(NuevoJuego[i].ToString());

                    }
                    Console.ReadKey();
                }
            
                else if (opcion == "4") 
                {
                    control = true;
                }
            }
            

        }
    }
}
