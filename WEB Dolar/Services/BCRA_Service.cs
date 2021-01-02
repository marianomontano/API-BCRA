using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WEB_Dolar.Models;

namespace WEB_Dolar.Services
{
    public class BCRA_Service
    {
        public static async Task<List<DolarModel>> ListarTodos()
        {
            string url = "https://api.estadisticasbcra.com/usd";
            using (HttpResponseMessage respuesta = await ApiHelper.Cliente.GetAsync(url))
            {
                if (respuesta.IsSuccessStatusCode)
                {
                    List<DolarModel> cotizaciones = await respuesta.Content.ReadAsAsync<List<DolarModel>>();
                    return cotizaciones;
                }
                else
                {
                    throw new Exception(respuesta.ReasonPhrase);
                }
            }
        }
    }
}