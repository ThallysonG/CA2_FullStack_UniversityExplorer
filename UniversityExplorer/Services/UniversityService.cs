using System.Net.Http.Json;
using UniversityExplorer.Models;

namespace UniversityExplorer.Services
{
    public class UniversityService
    {
        private readonly HttpClient _httpClient;

        public UniversityService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<University>> GetUniversitiesAsync(
            string country)
        {
            var url =
                $"http://universities.hipolabs.com/search?country={Uri.EscapeDataString(country)}";

            var universities = await _httpClient
                .GetFromJsonAsync<List<University>>(url);

            return universities ?? new List<University>();
        }
    }
}