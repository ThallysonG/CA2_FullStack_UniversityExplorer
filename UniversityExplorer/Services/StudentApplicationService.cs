using System.Net.Http.Json;
using UniversityExplorer.Models;

namespace UniversityExplorer.Services
{
    public class StudentApplicationService
    {
        private readonly HttpClient _httpClient;

        public StudentApplicationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // GET - Retrieve all student applications
        public async Task<List<StudentApplication>> GetApplicationsAsync()
        {
            var applications = await _httpClient
                .GetFromJsonAsync<List<StudentApplication>>(
                    "https://edutots.net/api/studentapplication");

            return applications ?? new List<StudentApplication>();
        }

        // POST - Create a new student application
        public async Task<bool> CreateApplicationAsync(
            StudentApplication application)
        {
            var response = await _httpClient.PostAsJsonAsync(
                "https://edutots.net/api/studentapplication",
                application);

            return response.IsSuccessStatusCode;
        }
        // GET - Find an application by ID
        public async Task<StudentApplication?> GetApplicationByIdAsync(int id)
        {
            var applications = await GetApplicationsAsync();

            return applications.FirstOrDefault(a => a.Id == id);
        }

        // PUT - Update an existing application
        public async Task<bool> UpdateApplicationAsync(
            StudentApplication application)
        {
            var response = await _httpClient.PutAsJsonAsync(
                $"https://edutots.net/api/studentapplication/{application.Id}",
                application);

            return response.IsSuccessStatusCode;
        }
    }
}