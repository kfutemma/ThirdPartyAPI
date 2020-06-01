using System;
using System.Threading.Tasks;
using Giphy.Libs.Models;

namespace Giphy.Libs.Services
{
    public interface IGiphyService
    {
        Task<GiphyModel> GetRandomGifBasedOnSearchCritera(string searchCritera);
    }
}
