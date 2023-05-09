using BanchoDotNet.Enum;
using Newtonsoft.Json;

namespace BanchoDotNet.Models.v1
{
    public class BanchoBeatmap
    {
        [JsonProperty("beatmapset_id")]
        public int BeatmapSetId { get; set; }

        [JsonProperty("beatmap_id")]
        public int BeatmapId { get; set; }

        [JsonProperty("approved")]
        public MapStatus MapStatus { get; set; }

        [JsonProperty("total_length")]
        public int TotalLength { get; set; }

        [JsonProperty("hit_length")]
        public int HitLength { get; set; }

        [JsonProperty("version")]
        public string DifficultyName { get; set; }

        [JsonProperty("diff_size")]
        public int CircleSize { get; set; }

        [JsonProperty("diff_overall")]
        public int OverallDifficulty { get; set; }

        [JsonProperty("diff_approach")]
        public int ApproachRate { get; set; }

        [JsonProperty("diff_drain")]
        public int HealthDrain { get; set; }

        [JsonProperty("mode")]
        public Enum.GameMode GameMode { get; set; }

        [JsonProperty("count_normal")]
        public int NormalCount { get; set; }

        [JsonProperty("count_slider")]
        public int SliderCount { get; set; }

        [JsonProperty("count_spinner")]
        public int SpinnerCount { get; set; }

        [JsonProperty("submit_date")]
        public string SubmitDate { get; set; }

        [JsonProperty("approved_date")]
        public string ApprovedDate { get; set; }

        [JsonProperty("last_update")]
        public string LastUpdate { get; set; }

        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("artist_unicode")]
        public string ArtistUnicode { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("title_unicode")]
        public string TitleUnicode { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }
        
        [JsonProperty("creator_id")]
        public int CreatorId { get; set; }
        
        [JsonProperty("bpm")]
        public int Bpm { get; set; }
        
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }
        
        [JsonProperty("genre_id")]
        public int GenreId { get; set; }
        
        [JsonProperty("language_id")]
        public int LanguageId { get; set; }
        
        [JsonProperty("favourite_count")]
        public int FavouriteCount { get; set; }
        
        [JsonProperty("rating")]
        public float Rating { get; set; }
        
        [JsonProperty("storyboard")]
        public int Storyboard { get; set; }
        
        [JsonProperty("video")]
        public int Video { get; set; }
        
        [JsonProperty("download_unavailable")]
        public int DownloadUnavailable { get; set; }
        
        [JsonProperty("audio_unavailable")]
        public int AudioUnavailable { get; set; }
        
        [JsonProperty("playcount")]
        public int Playcount { get; set; }
        
        [JsonProperty("passcount")]
        public int Passcount { get; set; }
        
        [JsonProperty("packs")]
        public string Packs { get; set; }
        
        [JsonProperty("diff_aim")]
        public string DifficultyAim { get; set; }
        
        [JsonProperty("diff_speed")]
        public string DifficultySpeed { get; set; }
        
        [JsonProperty("difficultyrating")]
        public float Difficulty { get; set; }
        
        [JsonProperty("events")]
        public BanchoEvent[] Events { get; set; }
    }
}