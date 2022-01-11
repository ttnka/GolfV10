using GolfV10.Server.Models.IFace;
using GolfV10.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfV10.Server.Models.Repo
{
    public class G170CampoRepo : IG170Campo
    {
        private readonly AppDbContext appDbContext;

        public G170CampoRepo(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<G170Campo> AddCampo(G170Campo campo)
        {
            var res = await appDbContext.Campos.AddAsync(campo);
            await appDbContext.SaveChangesAsync();
            return res.Entity;
        }
        public async Task<IEnumerable<G170Campo>> Buscar(string corto, string nombre, string desc, string ciudad, string pais)
        {
            IQueryable<G170Campo> querry = appDbContext.Campos;
            if (!string.IsNullOrEmpty(corto)) { querry = querry.Where(e => e.Corto.Contains(corto)); }
            if (!string.IsNullOrEmpty(nombre)) { querry = querry.Where(e => e.Nombre.Contains(nombre)); }
            if (!string.IsNullOrEmpty(ciudad)) { querry = querry.Where(e => e.Ciudad.Contains(ciudad)); }
            if (!string.IsNullOrEmpty(pais)) { querry = querry.Where(e => e.Pais.Contains(pais)); }
            return await querry.ToListAsync();
        }

        public async Task<G170Campo> GetCampo(int campoId)
        {
            return await appDbContext.Campos.FirstOrDefaultAsync(e => e.Id == campoId);
        }

        public async Task<IEnumerable<G170Campo>> GetCampos()
        {
            return await appDbContext.Campos.ToListAsync();
        }

        public async Task<G170Campo> UpdateCampo(G170Campo campo)
        {
            var res = await appDbContext.Campos.FirstOrDefaultAsync(e => e.Id == campo.Id);
            if (campo.Status == false)
            {
                res.Status = false;
            } else
            {
                res.Corto = campo.Corto;
                res.Nombre = campo.Nombre;
                res.Desc = campo.Desc;
                res.Ciudad = campo.Ciudad;
                res.Pais = campo.Pais;
                res.Estado = campo.Estado;
                res.Status = campo.Status;
            }
            await appDbContext.SaveChangesAsync();
            return res;
        }
    }
}
