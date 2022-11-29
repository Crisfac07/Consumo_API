using APIBooks.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;


namespace BooksMVC.Servicios
{
    public class Servicio_API:IServicio_API
    {
        //private readonly IHttpClientFactory _httpclient;
        //public Servicio_API(IHttpClientFactory httpClient) {
        //    _httpclient = httpClient;
        //}

        //public async Task<List<Author>> Listar() {
        //    var client = _httpclient.CreateClient("BackEnd");
        //    var json =  await client.GetStringAsync("/api/Authors");
        //    var list = JsonConvert.DeserializeObject<List<Author>>(json);
        //    return list;

        //}
        private readonly IHttpClientFactory _client;
        public Servicio_API(IHttpClientFactory client) {
            _client = client;
        }

        public async Task<List<Author>> Listar() {
            var cliente = _client.CreateClient("BackEnd");
            var json = await cliente.GetStringAsync("/api/...");
            var list = JsonConvert.DeserializeObject<List<Author>>(json);
            return list;
        }

        public async Task<Author> Obtener(int id)
        {
            var cliente = _client.CreateClient("BackEnd");
            var json = await cliente.GetStringAsync($´/ api / .../{id});
            var obj = JsonConvert.DeserializeObject<Author>(json);
            return obj;
        }

    }
}
