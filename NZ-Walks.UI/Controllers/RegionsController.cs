using Microsoft.AspNetCore.Mvc;
using NZ_Walks.UI.Models.DTOs;

namespace NZ_Walks.UI.Controllers
{
    public class RegionsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<RegionsController> _logger;

        public RegionsController(IHttpClientFactory httpClientFactory,ILogger<RegionsController> logger)
        {
            this._httpClientFactory = httpClientFactory;
            this._logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<RegionDTO> response = new List<RegionDTO>();
            try
            {
                var client = _httpClientFactory.CreateClient();
                var httpResponseMessage = await client.GetAsync("http://localhost:5239/api/Regions");

                // Check for successful status codes
                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    response.AddRange(await httpResponseMessage.Content.ReadFromJsonAsync<IEnumerable<RegionDTO>>());
                    return View(response);
                }
                else
                {
                    // Log the failure and provide user feedback
                    var errorContent = await httpResponseMessage.Content.ReadAsStringAsync();
                    _logger.LogError($"API call failed with status code {httpResponseMessage.StatusCode}. Error: {errorContent}");

                    // Return an error view with more details
                    return StatusCode((int)httpResponseMessage.StatusCode,
                        $"API Error: {httpResponseMessage.ReasonPhrase}. Details: {errorContent}");
                }
            }
            catch (Exception ex)
            {
                // Log the exception for debugging
                _logger.LogError(ex, "An unexpected error occurred while calling the API");

                // Return a generic error message to the user
                return StatusCode(500, "An unexpected error occurred. Our team has been notified.");
            }
        }
    }
}
