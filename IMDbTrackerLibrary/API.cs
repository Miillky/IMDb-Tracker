using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using IMDbTrackerLibrary.Models;
using IMDbTrackerLibrary.Models.API;
using Newtonsoft.Json;
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

        public async Task<List<string>> GetMostPopular(string endpoint) {

            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{apiUrl}/title/{endpoint}?purchaseCountry={apiCountry}&homeCountry={apiCountry}&currentCountry={apiCountry}"),
                Headers = { { "x-rapidapi-key", user.APIKey }, { "x-rapidapi-host", host } }
            };

            using(HttpResponseMessage response = await client.SendAsync(request)) {
                response.EnsureSuccessStatusCode();

                List<string> jsonIds = await response.Content.ReadFromJsonAsync<List<string>>();
                List<string> parsedIds = new List<string>();

                jsonIds.ForEach(id => parsedIds.Add(id.Split('/').ElementAt(2)));
                return parsedIds;
            }
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

            using(HttpResponseMessage response = await client.SendAsync(request)) {
                response.EnsureSuccessStatusCode();
                MovieDetails movie = await response.Content.ReadFromJsonAsync<MovieDetails>();
                movie.Id = movieId;
                return movie;
            }
        }

        public async Task<List<ShowSeason>> GetShowSeasons(string showId) {
            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{apiUrl}/title/get-seasons?tconst={showId}"),
                Headers = { { "x-rapidapi-key", user.APIKey }, { "x-rapidapi-host", host } }
            };

            using(HttpResponseMessage response = await client.SendAsync(request)) {
                response.EnsureSuccessStatusCode();
                string seasonsArr = await response.Content.ReadAsStringAsync();
                List<ShowSeason> seasons = JsonConvert.DeserializeObject<List<ShowSeason>>(seasonsArr);
                foreach(ShowSeason season in seasons) {
                    foreach(ShowSeasonEpisode episodes in season.Episodes) {
                        episodes.Id = episodes.Id.Split('/').ElementAt(2);
                    }
                }
                return seasons;
            }
        }

        public async Task<ShowDetails> GetShowDetails(string showId) {
            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{apiUrl}/title/get-overview-details?tconst={showId}&currentCountry={apiCountry}"),
                Headers = { { "x-rapidapi-key", user.APIKey }, { "x-rapidapi-host", host } }
            };

            using(HttpResponseMessage response = await client.SendAsync(request)) {
                response.EnsureSuccessStatusCode();
                ShowDetails show = await response.Content.ReadFromJsonAsync<ShowDetails>();
                show.Id = showId;
                return show;
            }
        }

        public async Task<EpisodeDetails> GetEpisodeDetails(string episodeId) {
            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{apiUrl}/title/get-overview-details?tconst={episodeId}&currentCountry={apiCountry}"),
                Headers = { { "x-rapidapi-key", user.APIKey }, { "x-rapidapi-host", host } }
            };

            using(HttpResponseMessage response = await client.SendAsync(request)) {
                response.EnsureSuccessStatusCode();
                EpisodeDetails episode = await response.Content.ReadFromJsonAsync<EpisodeDetails>();
                episode.Id = episodeId;
                return episode;
            }
        }
    }
}
