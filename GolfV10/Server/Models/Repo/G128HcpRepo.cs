using GolfV10.Server.Models.IFace;
using GolfV10.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfV10.Server.Models.Repo
{
    public class G128HcpRepo : IG128Hcp
    {
        private readonly AppDbContext appDbContext;

        public G128HcpRepo(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<G128Hcp> AddHcp(G128Hcp player)
        {
            var resultado = await appDbContext.Hcps.AddAsync(player);
            await appDbContext.SaveChangesAsync();
            return resultado.Entity;
        }

        public async Task<IEnumerable<G128Hcp>> Buscar(int ghin, string apodo, string nombre, string apellido, string campo)
        {
            IQueryable<G128Hcp> querry = appDbContext.Hcps;
            if (ghin > 0) { querry = querry.Where(e => e.Player.Ghin == ghin); }
            if (!string.IsNullOrEmpty(apodo)) { querry = querry.Where(e => e.Player.Apodo.Contains(apodo)); }
            if (!string.IsNullOrEmpty(nombre)) { querry = querry.Where(e => e.Player.Nombre.Contains(nombre)); }
            if (!string.IsNullOrEmpty(apellido)) { querry = querry.Where(e => e.Player.Nombre.Contains(apellido)); }
            if (!string.IsNullOrEmpty(campo)) { querry = querry.Where(e => e.Campo.Nombre.Contains(campo)); }
            return await querry.ToListAsync();
        }

        public async Task<G128Hcp> GetHcp(int playerId)
        {
            return await appDbContext.Hcps.FirstOrDefaultAsync(e => e.Player.Id == playerId);
        }

        public async Task<IEnumerable<G128Hcp>> GetHcps()
        {
            return await appDbContext.Hcps.ToListAsync();
        }

        public async Task<G128Hcp> UpdateHcp(G128Hcp player)
        {
            var hcpUpdate = await appDbContext.Hcps.FirstOrDefaultAsync(e => e.Player.Id == player.Id);
            if (player.Status == false)
            {
                hcpUpdate.Status = false;
            }
            else
            {
                hcpUpdate.Campo = player.Campo;
                hcpUpdate.Bandera = player.Bandera;
                hcpUpdate.Hcp = player.Hcp;
                hcpUpdate.Estado = player.Estado;
                hcpUpdate.Status = player.Status;
            }
            await appDbContext.SaveChangesAsync();
            return hcpUpdate;
        }
    }
}
