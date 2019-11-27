using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograFinal
{
    class Pelicula : PeliculaSerie
    {
        public Pelicula(string titulo, int año, string genero, string director, string sinopsis, int rating)
        {
            Titulo = titulo;
            Año = año;
            Genero = genero;
            Director = director;
            Sinopsis = sinopsis;
            Rating = rating;
            Seccion = "Película";
        }
    }
}
