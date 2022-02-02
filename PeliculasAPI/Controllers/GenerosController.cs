using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Logging;
using PeliculasAPI.Filtros;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasAPI.Controllers
{
    [Route("api/generos")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class GenerosController: ControllerBase
    {
      
       
  
        private readonly ILogger<GenerosController> logger;

        public GenerosController(
       
            ILogger<GenerosController> logger)
        {
    
           
            this.logger = logger;
        }

        [HttpGet]
       // [ResponseCache(Duration =60)]
     
        public ActionResult<List<Entidades.Genero>> Get()
        {
            return new List<Entidades.Genero>()
            {
                new Entidades.Genero()
                {
                    Id=1, Nombre="Comedia"
                }
            };
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
            throw new NotImplementedException();
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


    }
}
