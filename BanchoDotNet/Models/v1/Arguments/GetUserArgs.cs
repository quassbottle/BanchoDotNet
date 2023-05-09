using BanchoDotNet.Reflection;

namespace BanchoDotNet.Models.v1.Arguments
{
    public class GetUserArgs : ApiArgs
    {
        [ApiArgument("u")]
        public int? UserId { get; set; }
        
        [ApiArgument("u")]
        public string Username { get; set; }
        
        [ApiArgument("m")]
        public Enum.GameMode? Mode { get; set; }
        
        [ApiArgument("event_days")]
        public int? EventDays { get; set; }
    }
}