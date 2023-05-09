using System.Threading.Tasks;
using BanchoDotNet.Models.v1;
using BanchoDotNet.Models.v1.Arguments;

namespace BanchoDotNet
{
    public class OsuApi
    {
        public string Token { get; }

        private readonly string _endpoint = "https://osu.ppy.sh/api/";
        private readonly OsuRequestHandler _osuRequestHandler;

        public OsuApi(string token)
        {
            Token = token;
            _osuRequestHandler = new OsuRequestHandler(_endpoint, token);
        }

        public BanchoBeatmap[] GetBeatmaps(GetBeatmapsArgs args)
        {
            return GetBeatmapsAsync(args).GetAwaiter().GetResult();
        }

        public async Task<BanchoBeatmap[]> GetBeatmapsAsync(GetBeatmapsArgs args)
        {
            return (await _osuRequestHandler.GetResult("get_beatmaps", args.ParseProperties())).ToObject<BanchoBeatmap[]>();
        }

        public BanchoUser[] GetUser(GetUserArgs args)
        {
            return GetUserAsync(args).GetAwaiter().GetResult();
        }

        public async Task<BanchoUser[]> GetUserAsync(GetUserArgs args)
        {
            return (await _osuRequestHandler.GetResult("get_user", args.ParseProperties())).ToObject<BanchoUser[]>();
        }

        public BanchoScore[] GetScores(GetScoresArgs args)
        {
            return GetScoresAsync(args).GetAwaiter().GetResult();
        }
        
        public async Task<BanchoScore[]> GetScoresAsync(GetScoresArgs args)
        {
            return (await _osuRequestHandler.GetResult("get_scores", args.ParseProperties())).ToObject<BanchoScore[]>();
        }

        public BanchoScore[] GetUserBest(GetUserBestArgs args)
        {
            return GetUserBestAsync(args).GetAwaiter().GetResult();
        }
        
        public async Task<BanchoScore[]> GetUserBestAsync(GetUserBestArgs args)
        {
            return (await _osuRequestHandler.GetResult("get_user_best", args.ParseProperties())).ToObject<BanchoScore[]>();
        }

        public BanchoScore GetUserRecent(GetUserRecentArgs args)
        {
            return GetUserRecentAsync(args).GetAwaiter().GetResult();
        }
        
        public async Task<BanchoScore> GetUserRecentAsync(GetUserRecentArgs args)
        {
            return (await _osuRequestHandler.GetResult("get_user_recent", args.ParseProperties())).ToObject<BanchoScore>();
        }

        public BanchoMultiplayerMatch GetMatch(long matchId)
        {
            return GetMatchAsync(matchId).GetAwaiter().GetResult();
        }

        public async Task<BanchoMultiplayerMatch> GetMatchAsync(long matchId)
        {
            return (await _osuRequestHandler.GetResult("get_match", "mp=" + matchId)).ToObject<BanchoMultiplayerMatch>();
        }
    }
}