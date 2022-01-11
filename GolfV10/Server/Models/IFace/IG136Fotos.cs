using GolfV10.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfV10.Server.Models.IFace
{
    public interface IG136Fotos
    {
        Task<IEnumerable<G136Foto>> Buscar(int playerId, string titulo, DateTime bday);
        Task<IEnumerable<G136Foto>> GetFotos();
        Task<G136Foto> GetFoto(int fotoId);
        Task<G136Foto> AddFoto(G136Foto foto);
        Task<G136Foto> UpdateFoto(G136Foto foto);
    }
}
