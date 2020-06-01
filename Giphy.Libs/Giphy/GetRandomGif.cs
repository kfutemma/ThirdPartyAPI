using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Giphy.Libs.Models;

namespace Giphy.Libs.Giphy
{
    public class GetRandomGif : IGetRandomGif
    {
        public async Task<GiphyModel> ReturnRandomGifBasedOnTag(string searchCritera)
        {
            const string giphyKey = "";

            using (var client = new HttpClient())
            {
                var url = new Uri("");
                
                var response = await client.GetAsync(url);

                string json;
                using (var content = response.Content)
                {
                    json = await content.ReadAsStringAsync();
                }
                
                return JsonConvert.DeserializeObject<GiphyModel>(json);
            }
        }
    }
}