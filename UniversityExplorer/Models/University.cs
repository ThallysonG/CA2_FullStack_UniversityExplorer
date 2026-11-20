using System.Text.Json.Serialization;

namespace UniversityExplorer.Models
{
    public class University
    {
        [JsonPropertyName("name")]
        public string UniversityName { get; set; } = string.Empty;

        [JsonPropertyName("country")]
        public string Country { get; set; } = string.Empty;

        [JsonPropertyName("web_pages")]
        public List<string> Websites { get; set; } = new();

        [JsonPropertyName("domains")]
        public List<string> Domains { get; set; } = new();

        [JsonIgnore]
        public string Website => Websites.FirstOrDefault() ?? "";

        [JsonIgnore]
        public string Domain => Domains.FirstOrDefault() ?? "";
    }
}