using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Logging;
using PeliculasAPI.Filtros;
using PeliculasAPI.Repositorio;
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
      
        private readonly IRepositorio repositorio;
        private readonly WeatherForecastController weatherForecastController;
        private readonly ILogger<GenerosController> logger;

        public GenerosController(Repositorio.IRepositorio repositorio, 
            WeatherForecastController weatherForecastController,
            ILogger<GenerosController> logger)
        {
            this.repositorio = repositorio;
            this.weatherForecastController = weatherForecastController;
            this.logger = logger;
        }

        [HttpGet]
       // [ResponseCache(Duration =60)]
        [ServiceFilter(typeof(MiFiltroDeAccion))]
        public ActionResult<List<Entidades.Genero>> Get()
        {
            logger.LogInformation("Mostrar los generos");
            return repositorio.ObtenerTodosLosGeneros();
        }

        [HttpGet("guid")]
        public ActionResult<Guid> GetGUID()
        {
            return Ok(new
            { 
            GUID_GenerosController = repositorio.ObternerGUID(),
            GUID_WeatherForecastController = weatherForecastController.ObtenerGUIDWeatherForecastController()
            });
        }



        [HttpGet("{Id:int}")]
       
        //Task es como una promesa para enviar 
        //BindRequired es para hacer obligatorio un parametro de peticion

        public async Task<ActionResult<Entidades.Genero>> Get(int Id, [BindRequired] string nombre)
        {

            logger.LogDebug("Obteniendo genero por id {Id}");

            var genero = await repositorio.obtenerPorId(Id);

            if (genero == null)
            {
                throw new ApplicationException($"El genero de if {Id} no fue encontrado");
                logger.LogWarning($"no se pudo encontrar el genero del id {Id}");
                return NotFound();
            }
            
            return genero;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Entidades.Genero genero)
        {
            repositorio.CrearGenero(genero);
            return NoContent();
        }

        [HttpPut]
        public ActionResult Put([FromBody] Entidades.Genero genero)
        {
            return NoContent();

        }

        [HttpDelete]
        public ActionResult Delete()
        {
            return NoContent();
        }


    }
}
