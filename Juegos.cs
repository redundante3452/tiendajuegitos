using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaJuegos
{
    internal class Juegos
    {
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public int Id { get; set; }

        public void Agregar(string NombreJuego, int Id, string GeneroJuego)
        {
            this.Nombre = NombreJuego;
            this.Id = Id;   
            this.Genero = GeneroJuego;
        }
        

        public override string ToString()
        {
            return "Nombre:   " + Nombre + "   ID:   " + Id + "genero:   " + Genero;
        }
        public override int GetHashCode()
        {
            return Id;
        }

    }
}
