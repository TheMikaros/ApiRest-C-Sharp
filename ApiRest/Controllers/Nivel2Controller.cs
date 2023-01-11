using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Nivel2Controller : ControllerBase
    {

        //*********  METODOS HTTP

        // GET: api/Nivel2
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Nivel2/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Nivel2
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Nivel2/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        // PATCH: api/ApiWithActions/5
        [HttpPatch("{id}")]
        public void Patch(int id)
        {
        }


        //*********  Codigos de Estado
        // GET: api/Nivel2/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult GetEstado200(int id)
        {
            return Ok(); //devuelve un codigo 200
        }

        // GET: api/Nivel2/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult GetEstado400(int id)
        {
            return BadRequest(); //devuelve un codigo 400
        }

        // GET: api/Nivel2/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult GetEstado401(int id)
        {
            return Unauthorized(); //devuelve un codigo 401
        }

        // GET: api/Nivel2/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult GetEstado500(int id)
        {
            return StatusCode(StatusCodes.Status500InternalServerError); //devuelve un codigo 500
        }

        // GET: api/Nivel2/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult GetEstado500_2(int id)
        {

            //logica de negocio que falla

            throw new Exception("Error en al aplicacion"); //devuelve un codigo 500
        }

        //Ejemplo MAL USO
        // GET: api/Nivel2/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult GetEstado200_Mal(int id)
        {
            var returnObject = new
            {
                correcto =  false,
                codigo = 221,
                error = "datos insuficientes"
            };

            return Ok(returnObject); //devuelve un codigo 200
        }

        //****** Tipos y formatos de contenido.

        //Petición
        //========
        //GET /cliente/5
        //Accept: application/pdf, application/json

        //Respuesta
        //=========
        //Status Code 200
        //Content-Type: application/pdf

    }
}
