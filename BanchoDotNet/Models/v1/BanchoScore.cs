using BanchoDotNet.Enum;
using Newtonsoft.Json;

namespace BanchoDotNet.Models.v1
{
    public class BanchoScore
    {
        [JsonProperty("beatmap_id")]
        public int BeatmapId { get; set; }
        
        [JsonProperty("score_id")]
        public long ScoreId { get; set; }
        
        [JsonProperty("score")]
        public int Points { get; set; }
        
        [JsonProperty("maxcombo")]
        public int MaxCombo { get; set; }
        
        [JsonProperty("count50")]
        public int Count50 { get; set; }
        
        [JsonProperty("count100")]
        public int Count100 { get; set; }
        
        [JsonProperty("count300")]
        public int Count300 { get; set; }
        
        [JsonProperty("countmiss")]
        public int MissCount { get; set; }
        
        [JsonProperty("countkatu")]
        public int KatuCount { get; set; }
        
        [JsonProperty("countgeki")]
        public int GekiCount { get; set; }
        
        [JsonProperty("perfect")]
        public int PerfectCount { get; set; }
        
        [JsonProperty("enabled_mods")]
        public int Mods { get; set; }
        
        [JsonProperty("user_id")]
        public int UserId { get; set; }
        
        [JsonProperty("date")]
        public string Date { get; set; }
        
        [JsonProperty("rank")]
        public Rank Rank { get; set; }
        
        [JsonProperty("pp")]
        public float Pp { get; set; }
        
        [JsonProperty("replay_available")]
        public int ReplayAvailable { get; set; }
    }
}