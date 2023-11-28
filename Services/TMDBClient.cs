using BlazorMovie.Models;
using BlazorMovie.Pages;
using System.Net.Http.Json;

namespace BlazorMovie.Services
{
    public class TMDBClient
    {
        private readonly HttpClient _httpClient;

        public TMDBClient(HttpClient httpClient, IConfiguration config)
        {
            _httpClient = httpClient;

            _httpClient.BaseAddress = new Uri("https://api.themoviedb.org/3/");
            _httpClient.DefaultRequestHeaders.Accept.Add(new("application/json"));

            string apiKey = config["TMDBKey"] ?? throw new Exception("TMDBKey not found!");
            _httpClient.DefaultRequestHeaders.Authorization = new("Bearer", apiKey);
        }

        public Task<PopularMoviePagedResponse?> GetPopularMoviesAsync()
        {
            return _httpClient.GetFromJsonAsync<PopularMoviePagedResponse>("movie/popular");
        }

        public Task<MovieDetails?> GetMovieDetailsAaync(int id)
        {
            return _httpClient.GetFromJsonAsync<MovieDetails>($"movie/{id}");
        }
        public Task<ActorDetails?> GetActorDetailsAsync(int id)
        {
            return _httpClient.GetFromJsonAsync<ActorDetails>($"person/{id}");
        }

    }
}
