using GolfV10.Client.Servicios.IFaceServ;
using GolfV10.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace GolfV10.Client.Servicios.Serv
{
    public class G120PlayerServ : IG120PlayerServ
    {
        private readonly HttpClient httpClient;

        public G120PlayerServ(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<G120Player> AddPlayer(G120Player player)
        {
            var newPlayer = await httpClient.PostAsJsonAsync<G120Player>("api/player", player);
            return newPlayer.IsSuccessStatusCode ? await newPlayer.Content.ReadFromJsonAsync<G120Player>() : null;
        }

        public async Task<IEnumerable<G120Player>> Buscar(int ghin, string apodo, string nombre, string paterno, DateTime bday)
        {
            var resultado = "";
            if (ghin > -1) { resultado = resultado + "ghin=" + ghin + "&"; }
            if(!string.IsNullOrEmpty(apodo)) { resultado = resultado + apodo + "&"; }
            if(!string.IsNullOrEmpty(nombre)) { resultado = resultado + nombre + "&"; }
            if(!string.IsNullOrEmpty(paterno)) { resultado = resultado + paterno + "&"; }
            if (resultado != "") { resultado = "api/player/filtro?" + resultado; }
            return await httpClient.GetFromJsonAsync<IEnumerable<G120Player>>(resultado);
        }

        public async Task<G120Player> GetPlayer(int playerId)
        {
            return await httpClient.GetFromJsonAsync<G120Player>($"api/player/{playerId}");
        }

        public async Task<IEnumerable<G120Player>> GetPlayers()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<G120Player>>("api/player");
        }

        public async Task<G120Player> UpdatePlayer(G120Player player)
        {
            var newPlayer = await httpClient.PutAsJsonAsync<G120Player>("api/player", player);
            return newPlayer.IsSuccessStatusCode ? await newPlayer.Content.ReadFromJsonAsync<G120Player>() : null;
        }
    }
}
