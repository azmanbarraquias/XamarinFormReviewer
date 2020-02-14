using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XamarinForms.G_DataAccess._Exercises.NetflixRoulette.Models;

namespace XamarinForms.G_DataAccess._Exercises.NetflixRoulette.Services
{
    public class MovieServiceNR
    {
        public static readonly int MinSearchLength = 5;

        private const string Url = "http://netflixroulette.net/api/api.php";
        private readonly HttpClient _client = new HttpClient();

        public async Task<IEnumerable<MovieNR>> FindMoviesByActor(string actor)
        {
            if (actor.Length < MinSearchLength)
                return Enumerable.Empty<MovieNR>();

            var response = await _client.GetAsync($"{Url}?actor={actor}");

            if (response.StatusCode == HttpStatusCode.NotFound)
                return Enumerable.Empty<MovieNR>();

            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<MovieNR>>(content);
        }

        public async Task<MovieNR> GetMovie(string title)
        {
            var response = await _client.GetAsync($"{Url}?title={title}");

            if (response.StatusCode == HttpStatusCode.NotFound)
                return null;

            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<MovieNR>(content);
        }
    }
}
