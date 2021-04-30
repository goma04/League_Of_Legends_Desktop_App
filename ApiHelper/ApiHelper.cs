using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace API_GUI
{
    public static class ApiHelper
    {
        public static HttpClient ApiClient { get; set; }
        public static string DeveloperKey { get; set; } = "RGAPI-7771bef7-7de7-40e6-895a-5c13f5d011bb";

        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
