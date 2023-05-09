using System.Threading.Tasks;
using Flurl.Http;
using Newtonsoft.Json.Linq;

namespace BanchoDotNet
{
    internal class OsuRequestHandler
    {
        private string _endPoint;
        private string _token;
        
        public OsuRequestHandler(string endPoint, string token)
        {
            _endPoint = endPoint;
            _token = token;
        }

        public async Task<JToken> GetResult(string method, string request)
        {
            var result = await $"{_endPoint}{method}?k={_token}&{request}".GetStringAsync();
            return JToken.Parse(result);
        }
    }
}