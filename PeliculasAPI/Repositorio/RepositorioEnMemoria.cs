using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasAPI.Repositorio
{
    public class RepositorioEnMemoria : IRepositorio
    {

        private List<Entidades.Genero> _generos;
        public RepositorioEnMemoria()
        {

            _generos = new List<Entidades.Genero>()
            {
                new Entidades.Genero(){Id = 1, Nombre ="Comedia"},
                new Entidades.Genero(){Id = 2, Nombre ="Drama"},
            };

        }

        public List<Entidades.Genero> ObtenerTodosLosGeneros()
        {
            return _generos;
        }


    }
}
