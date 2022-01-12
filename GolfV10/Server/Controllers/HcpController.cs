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
    public class HcpController : ControllerBase
    {
        private readonly IG128Hcp hcpFace;
        public HcpController(IG128Hcp hcpFace)
        {
            this.hcpFace = hcpFace;
        }
        [HttpGet]
        public async Task<ActionResult> GetHcps()
        {
            try
            {
                return Ok(await hcpFace.GetHcps());
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error al leer la base de datos, buscando Hcp de los jugadroes");
            }
        }

        [HttpGet("{playerid:int}")]
        public async Task<ActionResult<G128Hcp>> GetHcp(int playerid)
        {
            try
            {
                var resultado = await hcpFace.GetHcp(playerid);
                return resultado != null ? resultado : NotFound();

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error al leer la base de datos, buscando Hcp de los jugadroe");
            }
        }
        [HttpPost]
        public async Task<ActionResult<G128Hcp>> AddHcp(G128Hcp hcp)
        {
            try
            {
                if (hcp == null) return BadRequest();
                var newHcp = await hcpFace.AddHcp(hcp);
                return CreatedAtAction(nameof(GetHcp), new { hcp = newHcp.Id }, newHcp);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error al intentar agregar la base de datos, buscando Hcp de los jugadroe");
            }
        }

        [HttpPut]
        public async Task<ActionResult<G128Hcp>> UpdateHcp(G128Hcp hcp)
        {
            try
            {
                return hcp != null ? await hcpFace.UpdateHcp(hcp) : NotFound($"No se encontro el registro hcp para actualizarlo");
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error al intentar actualizar la base de datos, del jugador");
            }
        }
    }
}
