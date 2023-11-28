using System.Text.Json.Serialization;

namespace BlazorMovie.Models
{
    public class ActorDetails
    {

        //person/{person_id}

        [JsonPropertyName("adult")]
        public bool Adult { get; set; }

        [JsonPropertyName("also_known_as")]
        public string[] AlsoKnownAs { get; set; } = [];

        [JsonPropertyName("biography")]
        public string Biography { get; set; } = string.Empty;

        [JsonPropertyName("birthday")]
        public string Birthday { get; set; } = string.Empty;

        [JsonPropertyName("deathday")]
        public string? Deathday { get; set; }

        [JsonPropertyName("gender")]
        public int Gender { get; set; }

        [JsonPropertyName("homepage")]
        public string? Homepage { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("imdb_id")]
        public string? ImdbId { get; set; }

        [JsonPropertyName("known_for_department")]
        public string KnownForDepartment { get; set; } = string.Empty;

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("place_of_birth")]
        public string PlaceOfBirth { get; set; } = string.Empty;

        [JsonPropertyName("popularity")]
        public float Popularity { get; set; }

        [JsonPropertyName("profile_path")]
        public string? ProfilePath { get; set; }
    }
}
