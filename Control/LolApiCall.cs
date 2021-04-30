using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API_GUI.League;

namespace API_GUI.Control
{
    public static class LolApiCall
    {
        public static async Task<SummonerModel> LoadSummonerByName(string name)
        {
            var summoner = await SummonerProcessor.LoadSummoner(name);
            return summoner;
        }
    }
}
