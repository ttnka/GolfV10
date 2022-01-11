using GolfV10.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfV10.Client.Servicios.IFaceServ
{
    public interface IG120PlayerServ
    {
        Task<IEnumerable<G120Player>> Buscar(int ghin, string apodo, string nombre, string paterno, DateTime bday);
        Task<IEnumerable<G120Player>> GetPlayers();
        Task<G120Player> GetPlayer(int playerId);
        Task<G120Player> AddPlayer(G120Player player);
        Task<G120Player> UpdatePlayer(G120Player player);
    }
}
