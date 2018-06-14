using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace App.Core
{
    public class HttpUtility
    {
        private const string Url = "http://newsapi.org/v2/top-headlines?country=au&category=business&apiKey=364a811e3dfc495b9cdfb4f4a3e70112";
        private readonly HttpClient _cliebnt = new HttpClient();

        public async Task<News> GetNews()
        {
            string content = await _cliebnt.GetStringAsync(Url);
            var news = JsonConvert.DeserializeObject<News>(content);
            return news;
        }
    }
}
