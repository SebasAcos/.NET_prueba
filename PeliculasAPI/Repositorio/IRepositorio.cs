using PeliculasAPI.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasAPI.Repositorio
{
   public interface IRepositorio
    {
        void CrearGenero(Genero genero);

        //Task metodo asingrono 
        Task<Genero> obtenerPorId(int Id);
        List<Genero> ObtenerTodosLosGeneros();
        Guid ObternerGUID();
    }
}
