using GolfV10.Server.Models.IFace;
using GolfV10.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfV10.Server.Models.Repo
{
    public class G120PlayerRepo : IG120Player
    {
        private readonly AppDbContext appDbContext;

        public G120PlayerRepo(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<G120Player> AddPlayer(G120Player player)
        {
            var resultado = await appDbContext.Players.AddAsync(player);
            await appDbContext.SaveChangesAsync();
            return resultado.Entity;
        }
        public async Task<IEnumerable<G120Player>> Buscar(int ghin, string apodo, string nombre, string paterno, DateTime bday)
        {
            IQueryable<G120Player> querry = appDbContext.Players;
            if (ghin > -1) { querry = querry.Where(e => e.Ghin == ghin); }
            if (!string.IsNullOrEmpty(apodo)) { querry = querry.Where(e => e.Apodo.Contains(apodo)); }
            if (!string.IsNullOrEmpty(nombre)) { querry = querry.Where(e => e.Nombre.Contains(nombre)); }
            if (!string.IsNullOrEmpty(paterno)) { querry = querry.Where(e => e.Paterno.Contains(paterno)); }

            return await querry.ToListAsync();
        }
        public async Task<G120Player> GetPlayer(int playerId)
        {
            return await appDbContext.Players.FirstOrDefaultAsync(e => e.Id == playerId);
        }
        public async Task<IEnumerable<G120Player>> GetPlayers()
        {
            return await appDbContext.Players.ToListAsync();
        }
        public async Task<G120Player> UpdatePlayer(G120Player player)
        {
            var playerUpdate = await appDbContext.Players.FirstOrDefaultAsync(e => e.Id == player.Id);
            if (player.Status == false)
            {
                playerUpdate.Status = false;
            }
            else
            {
                playerUpdate.Ghin = player.Ghin;
                playerUpdate.Apodo = player.Apodo;
                playerUpdate.Nombre = player.Nombre;
                playerUpdate.Paterno = player.Paterno;
                playerUpdate.Bday = player.Bday;
                playerUpdate.Estado = player.Estado;
                playerUpdate.Status = player.Status;
            }
            await appDbContext.SaveChangesAsync();
            return playerUpdate;
        }

    }
}
