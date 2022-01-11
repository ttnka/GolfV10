using GolfV10.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfV10.Server.Models.IFace
{
    public interface IG170Campo
    {
        Task<IEnumerable<G170Campo>> Buscar(string corto, string nombre, string desc, string ciudad, string pais);
        Task<IEnumerable<G170Campo>> GetCampos();
        Task<G170Campo> GetCampo(int campoId);
        Task<G170Campo> AddCampo(G170Campo campo);
        Task<G170Campo> UpdateCampo(G170Campo campo);
    }
}
