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
            _guid = Guid.NewGuid();
        }

        public Guid _guid;

        public List<Entidades.Genero> ObtenerTodosLosGeneros()
        {
            return _generos;
        }

        //metodo asincrono con async
        public async Task<Entidades.Genero> obtenerPorId(int Id)
        {
            //tiempo de espera para dar resultado
            await Task.Delay(1); 

            return _generos.FirstOrDefault(x => x.Id == Id);
        }

        public Guid ObternerGUID()
        {
            return _guid;
        }

        public void CrearGenero(Entidades.Genero genero)
        {
            genero.Id = _generos.Count() + 1;
            _generos.Add(genero);
        }
         
    }
}
