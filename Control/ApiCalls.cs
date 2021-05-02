using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API_GUI.League;
using API_GUI.Model;

namespace API_GUI.Control
{
    public static class ApiCalls
    {
        public static async Task<SummonerModel> LoadSummonerByName(string name, string region)
        {
            var summoner = await SummonerProcessor.LoadSummoner(name, region);
            return summoner;
        }

        public static async Task<MatchModel> LoadMatchByMatchId(string matchId)
        {
            var match = await MatchProcessor.LoadMatchById(matchId);
            return match;
        }
    }
}
