using Newtonsoft.Json;

namespace BanchoDotNet.Models.v1
{
    public class BanchoEvent
    {
        [JsonProperty("display_html")]
        public string DisplayHtml { get; set; }
        
        [JsonProperty("beatmap_id")]
        public int BeatmapId { get; set; }
        
        [JsonProperty("beatmapset_id")]
        public int BeatmapSetId { get; set; }
        
        [JsonProperty("date")]
        public string Date { get; set; }
        
        [JsonProperty("epicfactor")]
        public int EpicFactor { get; set; }
    }
}