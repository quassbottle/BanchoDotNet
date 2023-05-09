using BanchoDotNet.Reflection;

namespace BanchoDotNet.Models.v1.Arguments
{
    public class GetBeatmapsArgs : ApiArgs
    {
        [ApiArgument("s")]
        public int? BeatmapSetId { get; set; } 
        
        [ApiArgument("b")]
        public int? BeatmapId { get; set; }
        
        [ApiArgument("u")]
        public string Username { get; set; }
        
        [ApiArgument("u")]
        public int? UserId { get; set; }
        
        [ApiArgument("m")]
        public Enum.GameMode? Mode { get; set; }

        [ApiArgument("a")]
        public int? IncludeConverts { get; set; }
        
        [ApiArgument("h")]
        public string Hash { get; set; }
        
        [ApiArgument("limit")]
        public int? Limit { get; set; }
        
        [ApiArgument("mods")]
        public int? Mods { get; set; }
    }
}