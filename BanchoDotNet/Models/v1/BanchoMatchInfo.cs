using Newtonsoft.Json;

namespace BanchoDotNet.Models.v1
{
    public class BanchoMatchInfo
    {
        [JsonProperty("match_id")]
        public long MatchId { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("start_time")]
        public string StartTime { get; set; }
        
        [JsonProperty("end_time")]
        public string EndTime { get; set; }
    }
}