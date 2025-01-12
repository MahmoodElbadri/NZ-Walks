using Microsoft.AspNetCore.Mvc;
using NZ_Walks.UI.Models.DTOs;
using NZ_Walks.UI.Models.ViewModels;
using System.Text;
using System.Text.Json;

namespace NZ_Walks.UI.Controllers
{
    public class WalksController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<WalksController> _logger;

        public WalksController(IHttpClientFactory httpClientFactory, ILogger<WalksController> logger)
        {
            this._httpClientFactory = httpClientFactory;
            this._logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var response = new List<WalksDTO>();
            try
            {
                var client = _httpClientFactory.CreateClient();
                var httpResponseMessage = await client.GetAsync("http://localhost:5239/api/Walks");
                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    response.AddRange(await httpResponseMessage.Content.ReadFromJsonAsync<IEnumerable<WalksDTO>>());
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
