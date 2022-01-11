using GolfV10.Server.Models.IFace;
using GolfV10.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfV10.Server.Models.Repo
{
    public class G136FotoRepo : IG136Fotos
    {
        private readonly AppDbContext appDbContext;

        public G136FotoRepo(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<G136Foto> AddFoto(G136Foto foto)
        {
            var resultado = await appDbContext.Fotos.AddAsync(foto);
            await appDbContext.SaveChangesAsync();
            return resultado.Entity;
        }

        public async Task<IEnumerable<G136Foto>> Buscar(int playerId, string titulo, DateTime bday)
        {
            IQueryable<G136Foto> querry = appDbContext.Fotos;
            if (playerId > 0 ) { querry = querry.Where(e => e.Player == playerId); }
            if (!string.IsNullOrEmpty(titulo)) { querry = querry.Where(e => e.Titulo.Contains(titulo)); }
            return await querry.ToListAsync();
        }

        public async Task<G136Foto> GetFoto(int fotoId)
        {
            return await appDbContext.Fotos.FirstOrDefaultAsync(e => e.Id == fotoId);
        }

        public async Task<IEnumerable<G136Foto>> GetFotos()
        {
            return await appDbContext.Fotos.ToListAsync();
        }

        public async Task<G136Foto> UpdateFoto(G136Foto foto)
        {
            var res = await appDbContext.Fotos.FirstOrDefaultAsync(e => e.Id == foto.Id);
            if (foto.Status == false)
            {
                res.Status = false;
            } else
            {
                res.Fecha = foto.Fecha;
                res.Titulo = foto.Titulo;
                res.Player = foto.Player;
                res.Grupo = foto.Grupo;
                res.Foto = foto.Foto;
                res.Privada = foto.Privada;
                res.Estado = foto.Estado;
                res.Status = foto.Status;
            }
            await appDbContext.SaveChangesAsync();
            return res;
        }
    }
}
