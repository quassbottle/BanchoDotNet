using System.Collections.Generic;
using BanchoDotNet.Enum;
using Newtonsoft.Json;

namespace BanchoDotNet.Models.v1
{
    public class BanchoMultiplayerGame
    {
        [JsonProperty("game_id")]
        public long GameId { get; set; }
        
        [JsonProperty("start_time")]
        public string StartTime { get; set; }
        
        [JsonProperty("end_time")]
        public string EndTime { get; set; }
        
        [JsonProperty("beatmap_id")]
        public long BeatmapId { get; set; }
        
        [JsonProperty("play_mode")]
        public GameMode PlayMode { get; set; }
        
        [JsonProperty("match_type")]
        public int MatchType { get; set; }
        
        [JsonProperty("scoring_type")]
        public ScoreMode ScoreMode { get; set; }
        
        [JsonProperty("team_type")]
        public TeamMode TeamMode { get; set; }
        
        [JsonProperty("mods")]
        public int Mods { get; set; }
        
        [JsonProperty("scores")]
        public List<BanchoMultiplayerScore> Scores { get; set; }
    }
}