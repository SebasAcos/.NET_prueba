<<<<<<< Updated upstream
﻿using Microsoft.AspNetCore.Mvc;
using PeliculasAPI.Repositorio;
=======
﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Logging;
using PeliculasAPI.Filtros;

>>>>>>> Stashed changes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasAPI.Controllers
{
    [Route("api/generos")]
    public class GenerosController
    {
      
<<<<<<< Updated upstream
        private readonly IRepositorio repositorio;

        public GenerosController(Repositorio.IRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public 
=======

        
        private readonly ILogger<GenerosController> logger;


        public GenerosController( 
            ILogger<GenerosController> logger)
        {
          
        
            this.logger = logger;
        }

        [HttpGet]
       // [ResponseCache(Duration =60)]
        //[ServiceFilter(typeof(MiFiltroDeAccion))]
        public ActionResult<List<Entidades.Genero>> Get()
        {
           
            return new List<Entidades.Genero>() { new Entidades.Genero { Id = 1, Nombre = "comedia" } };
        }

   


        [HttpGet("{Id:int}")]
       
        //Task es como una promesa para enviar 
        //BindRequired es para hacer obligatorio un parametro de peticion

        public async Task<ActionResult<Entidades.Genero>> Get(int Id)
        {


            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult Post([FromBody] Entidades.Genero genero)
        {
            throw new NotImplementedException(); ;
        }

        [HttpPut]
        public ActionResult Put([FromBody] Entidades.Genero genero)
        {
            throw new NotImplementedException();

        }

        [HttpDelete]
        public ActionResult Delete()
        {
            throw new NotImplementedException();
        }
>>>>>>> Stashed changes


    }
}
