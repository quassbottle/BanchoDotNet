using System.Collections.Generic;
using Newtonsoft.Json;

namespace BanchoDotNet.Models.v1
{
    public class BanchoMultiplayerMatch
    {
        [JsonProperty("match")]
        public BanchoMatchInfo BanchoMatch { get; set; }
        
        [JsonProperty("games")]
        public List<BanchoMultiplayerGame> Games { get; set; }
    }
}