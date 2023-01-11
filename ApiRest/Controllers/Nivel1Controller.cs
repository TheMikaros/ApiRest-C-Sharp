using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ApiRest.Controllers
{
    [Route("api/facturas")]
    [ApiController]
    public class Nivel1Controller : ControllerBase
    {

        //*********** Las URIS no deben implicar acciones y deben ser unicas

        // GET api/facturas/5/editar
        [HttpGet("{id}/editar")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // GET api/facturas/5
        [HttpGet("{id}")]
        public ActionResult<string> GetEditar(int id)
        {
            return "value";
        }

        // *************  Las Uris deben ser independientes de formato

        // GET api/facturas/5.txt
        [HttpGet("{id}")]
        public ActionResult<string> GetFormato(string id)
        {
            return "value";
        }

        // GET api/facturas/5/formato/txt
        [HttpGet("{id}/formato/{format}")]
        public ActionResult<string> GetFormato(int id,string formato)
        {
            return "value";
        }

        //************ Las Uris deben contener una jeraquia logica

        // GET api/facturas/factura/15/cliente/45
        [HttpGet("factura/{idFactura}/cliente/{id}")]
        public ActionResult<string> GetFormato(int idFactura, int id)
        {
            return "value";
        }

        // GET api/facturas/cliente/45/factura/15
        [HttpGet("cliente/{id}/factura/{idFactura}")]
        public ActionResult<string> GetFactura(int id, int idFactura)
        {
            return "value";
        }

        //*************   Filtrado y otras operaciones

        // GET api/facturas/cliente/45/factura/15/orden/desc/fecha/25-12-2018
        [HttpGet("cliente/{id}/factura/{idFactura}/orden/{orden}/fecha/{fecha}")]
        public ActionResult<string> GetFacturaFiltro(int id, int idFactura,string orden,DateTime fecha)
        {
            return "value";
        }

        // GET api/facturas/cliente/45/factura/15?orden=desc&fecha=25-12-2018
        [HttpGet("cliente/{id}/factura/{idFactura}")]
        public ActionResult<string> GetFacturaFiltroBien(int id, int idFactura)
        {
            return "value";
        }
    }
}
