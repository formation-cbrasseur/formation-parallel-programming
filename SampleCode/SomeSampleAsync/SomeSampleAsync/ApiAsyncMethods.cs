using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SomeSampleAsync
{
    public static class ApiAsyncMethods
    {
        internal class FacebookFollowers
        {
            public int followers { get; set; }
        }

        public static async Task<int> GetFacebookFollowers(HttpClient client)
        {
            HttpResponseMessage response = await client.GetAsync("https://localhost:5001/Facebook");
            var jsonContent = await response.Content.ReadAsStringAsync();
            var followers = JsonSerializer.Deserialize<FacebookFollowers>(jsonContent);

            return followers.followers;
        }

        internal class TwitterFollowers
        {
            public int followers { get; set; }
        }

        public static async Task<int> GetTwitterFollowers(HttpClient client)
        {
            HttpResponseMessage response = await client.GetAsync("https://localhost:5001/Twitter");
            var jsonContent = await response.Content.ReadAsStringAsync();
            var followers = JsonSerializer.Deserialize<TwitterFollowers>(jsonContent);

            return followers.followers;
        }

        internal class InstagramFollowers
        {
            public int followers { get; set; }
        }

        public static async Task<int> GetInstagramFollowers(HttpClient client)
        {
            HttpResponseMessage response = await client.GetAsync("https://localhost:5001/Instagram");
            var jsonContent = await response.Content.ReadAsStringAsync();
            var followers = JsonSerializer.Deserialize<InstagramFollowers>(jsonContent);

            return followers.followers;
        }

        internal class Weather
        {
            public string summary { get; set; }
        }

        public static async Task<string> GetWeatherRandom(HttpClient client)
        {
            HttpResponseMessage response = await client.GetAsync("https://localhost:5001/Weather");
            var jsonContent = await response.Content.ReadAsStringAsync();
            var weather = JsonSerializer.Deserialize<Weather>(jsonContent);

            return weather.summary;
        }

        internal class TestFastEndpoint
        {
            public string test { get; set; }
        }

        public static async Task<string> GetTest(HttpClient client)
        {
            HttpResponseMessage response = await client.GetAsync("https://localhost:5001/api/test");
            var jsonContent = await response.Content.ReadAsStringAsync();
            var test = JsonSerializer.Deserialize<TestFastEndpoint>(jsonContent);

            return test.test;
        }
    }
}
