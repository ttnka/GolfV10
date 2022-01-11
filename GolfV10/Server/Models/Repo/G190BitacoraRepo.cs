using GolfV10.Server.Models.IFace;
using GolfV10.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfV10.Server.Models.Repo
{
    public class G190BitacoraRepo : IG190Bitacora
    {
        private readonly AppDbContext appDbContext;
        public G190BitacoraRepo(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<G190Bitacora> AddBitacora(G190Bitacora bitacora)
        {
            var bitacoraAdd = await appDbContext.Bitacoras.AddAsync(bitacora);
            await appDbContext.SaveChangesAsync();
            return bitacoraAdd.Entity;
        }

        public async Task<IEnumerable<G190Bitacora>> Buscar(int playerId, bool sitema, BitaAcciones? accion, string texto, DateTime fini, DateTime ffin)
        {
            IQueryable<G190Bitacora> querry = appDbContext.Bitacoras;
            if (playerId > 0) { querry = querry.Where(e => e.Id == playerId); }
            if (sitema) { querry = querry.Where(e => e.Sistema == true); }
            if (accion.HasValue) { querry = querry.Where(e => e.Accion == accion); }
            if (!string.IsNullOrEmpty(texto)) { querry = querry.Where(e => e.Desc.Contains(texto)); }
            if (fini != DateTime.MinValue && ffin != DateTime.MinValue)
            {
                querry = querry.Where(e => e.Fecha >= fini && e.Fecha <= ffin.AddDays(1));
            }
            else if (fini != DateTime.MinValue)
            {
                querry = querry.Where(e => e.Fecha >= fini && e.Fecha <= fini.AddDays(1));
            }
            else if (ffin != DateTime.MinValue)
            {
                querry = querry.Where(e => e.Fecha >= ffin && e.Fecha <= ffin.AddDays(1));
            }
            return await querry.ToListAsync();
        }

        public async Task<G190Bitacora> GetBitacora(int bitacoraId)
        {
            return await appDbContext.Bitacoras.FirstOrDefaultAsync(e => e.Id == bitacoraId);
        }

        public async Task<IEnumerable<G190Bitacora>> GetBitacoraAll()
        {
            return await appDbContext.Bitacoras.Where(e => e.Sistema == false).ToListAsync();
        }
    }
}
