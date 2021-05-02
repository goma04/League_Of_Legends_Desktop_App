using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using API_GUI.League;

namespace API_GUI
{
    class SummonerProcessor
    {
        public async static Task<SummonerModel> LoadSummoner(string summonerName, string region)
        {
            string url = $"https://{region}.api.riotgames.com/lol/summoner/v4/summoners/by-name/{summonerName}?api_key={ApiHelper.DeveloperKey}";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    SummonerModel summoner = await response.Content.ReadAsAsync<SummonerModel>();
                    return summoner;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }

        }
    }
}
