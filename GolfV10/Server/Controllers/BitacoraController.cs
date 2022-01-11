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
    public class BitacoraController : ControllerBase
    {
        private readonly IG190Bitacora bitaIFace;

        public BitacoraController(IG190Bitacora bitaIFace)
        {
            this.bitaIFace = bitaIFace;
        }
        [HttpGet]
        public async Task<ActionResult> GetBitacoraAll()
        {
            try
            {
                return Ok(await bitaIFace.GetBitacoraAll());
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error al leer la base de datos, buscando TODAS los registros de Bitacora");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<G190Bitacora>> GetBitacora(int bitacoraId)
        {
            try
            {
                var resultado = await bitaIFace.GetBitacora(bitacoraId);
                return resultado != null ? resultado : NotFound();
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error al leer la base de datos, al buscar el registro de la bitacora");
            }
        }
        [HttpPost]
        public async Task<ActionResult<G190Bitacora>> AddBitacora(G190Bitacora bitacora)
        {
            try
            {
                if (bitacora == null) return BadRequest();
                var newBitacora = await bitaIFace.AddBitacora(bitacora);
                return CreatedAtAction(nameof(GetBitacora), new { bitacora = bitacora.Id }, newBitacora);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error al intentar escribir un nuevo registro de la bitacora");
            }
        }
        

    }
}
