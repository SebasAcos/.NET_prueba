using Microsoft.AspNetCore.Mvc;
using PeliculasAPI.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasAPI.Controllers
{
    [Route("api/generos")]
    public class GenerosController
    {
      
        private readonly IRepositorio repositorio;

        public GenerosController(Repositorio.IRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public 


    }
}
