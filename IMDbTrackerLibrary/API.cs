using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using IMDbTrackerLibrary.Models;
using Newtonsoft.Json.Linq;

namespace IMDbTrackerLibrary {
    public class API {

        private User user;
        private string apiEndpoint;
        private string host;

        public API(User model) {

            user = model;
            apiEndpoint = GlobalConfig.AppKeyLookup("apiUrl");
            host = apiEndpoint.ToString().Replace("https://", "");
        }

        private HttpRequestMessage GetHttpRequestMessage() {
            HttpRequestMessage request = new HttpRequestMessage {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{apiEndpoint}/title/list-popular-genres"),
                Headers =
                {
                    { "x-rapidapi-key", user.APIKey },
                    { "x-rapidapi-host", host },
                },
            };
            return request;
        }

        public async Task<JToken> GetPopularGenres() {

            string json = string.Empty;

            HttpClient client = new HttpClient();
            HttpRequestMessage request = GetHttpRequestMessage();

            using(var response = await client.SendAsync(request)) {

                response.EnsureSuccessStatusCode();
                json = await response.Content.ReadAsStringAsync();
               
            }

            JObject jObject = JObject.Parse(json);
            JToken jGenre = jObject["genres"];

            return jGenre;

        }

    }
}
