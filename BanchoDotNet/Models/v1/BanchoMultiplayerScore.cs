using BanchoDotNet.Enum;
using Newtonsoft.Json;

namespace BanchoDotNet.Models.v1
{
    public class BanchoMultiplayerScore : BanchoScore
    {
        [JsonProperty("slot")]
        public int Slot { get; set; }
        
        [JsonProperty("team")]
        public Team Team { get; set; }
    }
}