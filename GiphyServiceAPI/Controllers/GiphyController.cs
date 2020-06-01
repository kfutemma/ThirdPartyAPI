using System;
using System.Threading.Tasks;
using Giphy.Libs.Services;
using Microsoft.AspNetCore.Mvc;


namespace GyphyServiceAPI.Controllers
{
    public class GiphyController : Controller
    {
        private readonly IGiphyService _giphyServices;

        public GiphyController(IGiphyService giphyService)
        {
            _giphyServices = giphyService;
        }

        [HttpGet]
        [Route("v1/giphy/random/{searchCritera}")]
        public async Task<IActionResult> GetRandomGif(string searchCritera)
        {
            var result = await _giphyServices.GetRandomGifBasedOnSearchCritera(searchCritera);

            return Ok(result);
        }
    }
    
}