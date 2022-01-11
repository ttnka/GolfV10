using GolfV10.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfV10.Server.Models.IFace
{
    public interface IG128Hcp
    {
        Task<IEnumerable<G128Hcp>> Buscar(int ghin, string apodo, string nombre, string apellido, string campo);
        Task<IEnumerable<G128Hcp>> GetHcps();
        Task<G128Hcp> GetHcp(int playerId);
        Task<G128Hcp> AddHcp(G128Hcp player);
        Task<G128Hcp> UpdateHcp(G128Hcp player);
    }
}
