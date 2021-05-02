using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_GUI.League
{
    public class SummonerModel
    {
        public string Id { get; set; }
        public int SummonerLevel { set; get; }

        private long revisionDateLong;
       
        
        public long RevisionDate
        {
            set
            {
                revisionDateLong = value;
            }
        }

        public DateTimeOffset ModifiedDate
        {
            get
            {
                return DateTimeOffset.FromUnixTimeMilliseconds(revisionDateLong);
            }
        }
    }
}
