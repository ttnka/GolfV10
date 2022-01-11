using GolfV10.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfV10.Server.Models.IFace
{
    public interface IG190Bitacora
    {
        Task<IEnumerable<G190Bitacora>> Buscar(int playerId, bool sitema, BitaAcciones? accion, string texto, DateTime fini, DateTime ffin);
        Task<IEnumerable<G190Bitacora>> GetBitacoraAll();
        Task<G190Bitacora> GetBitacora(int bitacoraId);
        Task<G190Bitacora> AddBitacora(G190Bitacora bitacora);
    }
}
