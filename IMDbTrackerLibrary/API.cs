using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using IMDbTrackerLibrary.Models;
using IMDbTrackerLibrary.Models.API;
using Newtonsoft.Json.Linq;

namespace IMDbTrackerLibrary {
    public class API {

        private readonly User user;
        private readonly string apiUrl;
        private readonly string apiCountry;
        private readonly string host;

        public API(User model) {

            user = model;
            apiUrl = GlobalConfig.AppKeyLookup("apiUrl");
            apiCountry = GlobalConfig.AppKeyLookup("apiCountry");
            host = apiUrl.ToString().Replace("https://", "");
        }

        public async Task<MovieTypes> GetPopularGenres() {

            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{apiUrl}/title/list-popular-genres"),
                Headers = { { "x-rapidapi-key", user.APIKey }, { "x-rapidapi-host", host } }
            };

            using(HttpResponseMessage response = await client.SendAsync(request)) {

                response.EnsureSuccessStatusCode();
                MovieTypes genre = await response.Content.ReadFromJsonAsync<MovieTypes>();
                return genre;
            }
        }

        public async Task<List<string>> GetTopRatedMovies() {

            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{apiUrl}/title/title/get-top-rated-movies"),
                Headers = { { "x-rapidapi-key", user.APIKey }, { "x-rapidapi-host", host } }
            };

            using(HttpResponseMessage response = await client.SendAsync(request)) {
                response.EnsureSuccessStatusCode();

                List<string> movieIds = await response.Content.ReadFromJsonAsync<List<string>>();
                List<string> parsedIds = new List<string>();

                movieIds.ForEach(movieId => parsedIds.Add(movieId.Split('/').ElementAt(2)));
                return parsedIds;
            }
        }

        public async Task<List<string>> GetMostPopularMovies() {

            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{apiUrl}/title/get-most-popular-movies?purchaseCountry={apiCountry}&homeCountry={apiCountry}&currentCountry={apiCountry}"),
                Headers = { { "x-rapidapi-key", user.APIKey }, { "x-rapidapi-host", host } }
            };

            using(HttpResponseMessage response = await client.SendAsync(request)) {
                response.EnsureSuccessStatusCode();

                List<string> movieIds = await response.Content.ReadFromJsonAsync<List<string>>();
                List<string> parsedIds = new List<string>();

                movieIds.ForEach(movieId => parsedIds.Add(movieId.Split('/').ElementAt(2)));
                return parsedIds;
            }
        }

        public async Task<List<string>> GetPopularMoviesByGenre(string genre) {

            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{apiUrl}/title/get-popular-movies-by-genre?genre={genre}"),
                Headers = { { "x-rapidapi-key", user.APIKey }, { "x-rapidapi-host", host } }
            };

            using(HttpResponseMessage response = await client.SendAsync(request)) {
                response.EnsureSuccessStatusCode();

                List<string> movieIds = await response.Content.ReadFromJsonAsync<List<string>>();
                List<string> parsedIds = new List<string>();

                movieIds.ForEach(movieId => parsedIds.Add(movieId.Split('/').ElementAt(2)));
                return parsedIds;
            }
        }

        public async Task<MovieDetails> GetMovieDetails(string movieId) {

            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{apiUrl}/title/get-overview-details?tconst={movieId}&currentCountry={apiCountry}"),
                Headers = { { "x-rapidapi-key", user.APIKey }, { "x-rapidapi-host", host } }
            };

            using(var response = await client.SendAsync(request)) {
                response.EnsureSuccessStatusCode();
                MovieDetails movie = await response.Content.ReadFromJsonAsync<MovieDetails>();
                movie.Id = movieId;
                return movie;
            }

        }
    }
}
