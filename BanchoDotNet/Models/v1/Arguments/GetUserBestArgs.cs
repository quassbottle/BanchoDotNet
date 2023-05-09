using BanchoDotNet.Reflection;

namespace BanchoDotNet.Models.v1.Arguments
{
    public class GetUserBestArgs : ApiArgs
    {
        [ApiArgument("u")]
        public int? UserId { get; set; }
        
        [ApiArgument("u")]
        public string Username { get; set; }
        
        [ApiArgument("m")]
        public Enum.GameMode? Mode { get; set; }
        
        [ApiArgument("limit")]
        public int? Limit { get; set; }
    }
}