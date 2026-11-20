using System.Text.Json.Serialization;

namespace UniversityExplorer.Models
{
    public class Country
    {
        [JsonPropertyName("name")]
        public string CountryName { get; set; } = string.Empty;

        public string Capital { get; set; } = string.Empty;

        public string Region { get; set; } = string.Empty;

        public long Population { get; set; }

        public string Flag { get; set; } = string.Empty;
    }
}