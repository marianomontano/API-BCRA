using System.Net.Http;
using System.Net.Http.Headers;

namespace WEB_Dolar.Services
{
    public static class ApiHelper
    {
        public static HttpClient Cliente { get; set; }

        public static void InicializarCliente()
        {
            Cliente = new HttpClient();
            Cliente.DefaultRequestHeaders.Accept.Clear();
            Cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            Cliente.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJleHAiOjE2MzMzOTA1NDIsInR5cGUiOiJleHRlcm5hbCIsInVzZXIiOiJtb250YW5vLm1hcmlhbm9AZ21haWwuY29tIn0.lrAX2GkDsS3O2csvf3fD4EOuygNEj5DOXOvkXeNYc2r4c1oW66lIdn-9hBhS7_89wfjTDPcaPrPCST85jsvv3Q");

        }
    }
}