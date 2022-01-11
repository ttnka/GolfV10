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
    public class FotosController : ControllerBase
    {
        private readonly IG136Fotos fotoIFace;
        public FotosController(IG136Fotos fotoIFace)
        {
            this.fotoIFace = fotoIFace;
        }
        [HttpGet("{filtro}")]
        public async Task<ActionResult<IEnumerable<G136Foto>>> Buscar(int playerId, string titulo, DateTime bday)
        {
            try
            {
                var resultado = await fotoIFace.Buscar(playerId, titulo, bday);
                return resultado.Any() ? Ok(resultado) : NotFound();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error al leer la base de datos, buscando fotografias");
            }
        }

        [HttpGet]
        public async Task<ActionResult> GetFotos()
        {
            try
            {
                return Ok(await fotoIFace.GetFotos());
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error al leer la base de datos, listado de fotografias");
            }
        }

        [HttpGet("{fotoid:int}")]
        public async Task<ActionResult<G136Foto>> GetFoto(int fotoId)
        {
            try
            {
                var resultado = await fotoIFace.GetFoto(fotoId);
                return resultado != null ? resultado : NotFound();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error al leer la base de datos, al traer una fotografia");
            }
        }
        [HttpPost]
        public async Task<ActionResult<G136Foto>> NewPlayer(G136Foto foto)
        {
            try
            {
                if (foto == null) return BadRequest();
                var newFoto = await fotoIFace.AddFoto(foto);
                return CreatedAtAction(nameof(GetFoto), new { foto = foto.Id }, newFoto);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error al intentar agregar una fotografia a la base de datos.");
            }
        }
        [HttpPatch]
        public async Task<ActionResult<G136Foto>> UpdatePlayer(G136Foto foto)
        {
            try
            {
                return foto != null ? await fotoIFace.UpdateFoto(foto) : NotFound($"Fotografia no encontrada {foto.Titulo} ");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error al intentar actualizar la base de datos, de la fotografia.");
            }
        }

    }
}
