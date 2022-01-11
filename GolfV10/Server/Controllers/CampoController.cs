using GolfV10.Server.Models.IFace;
using GolfV10.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfV10.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampoController : ControllerBase
    {
        private readonly IG170Campo campoIFace;
        public CampoController(IG170Campo campoIFace)
        {
            this.campoIFace = campoIFace;
        }
        [HttpGet("{filtro}")]
        public async Task<ActionResult<IEnumerable<G170Campo>>> Buscar(string corto, string nombre, string desc, string ciudad, string pais)        
        {
            try
            {
                var resultado = await campoIFace.Buscar(corto, nombre, desc, ciudad, pais);
                return resultado.Any() ? Ok(resultado) : NotFound();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error al leer la base de datos, buscando campos");
            }
        }

        [HttpGet]
        public async Task<ActionResult> GetCampos()
        {
            try
            {
                return Ok(await campoIFace.GetCampos());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error al leer la base de datos, listado de campos");
            }
        }

        [HttpGet("{campoid:int}")]
        public async Task<ActionResult<G170Campo>> GetCampo(int campoId)
        {
            try
            {
                var resultado = await campoIFace.GetCampo(campoId);
                return resultado != null ? resultado : NotFound();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error al leer la base de datos, buscando un campo");
            }
        }
        [HttpPost]
        public async Task<ActionResult<G170Campo>> NewCampo(G170Campo campo)
        {
            try
            {
                if (campo == null) return BadRequest();
                var newCampo = await campoIFace.AddCampo(campo);
                return CreatedAtAction(nameof(GetCampo), new { campo = campo.Id }, newCampo);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error al intentar crear un nuevo campo en la base de datos.");
            }
        }
        [HttpPatch]
        public async Task<ActionResult<G170Campo>> UpdatePlayer(G170Campo campo)
        {
            try
            {
                return campo != null ? await campoIFace.UpdateCampo(campo) : NotFound($"Campo {campo.Corto} {campo.Nombre} no fue encontrado");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error al intentar actualizar la base de datos, del campo");
            }
        }

    }
}
