using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograFinal
{
    class Serie : PeliculaSerie
    {
        public Serie(string titulo, int año, string genero, string director, string sinopsis, int rating, int temporadas)
        {
            Titulo = titulo;
            Año = año;
            Genero = genero;
            Director = director;
            Sinopsis = sinopsis;
            Rating = rating;
            Temporadas = temporadas;
            Seccion = "Serie";
        }
    }
}
