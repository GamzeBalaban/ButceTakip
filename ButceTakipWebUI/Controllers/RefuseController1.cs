using ButceTakipWebUI.Dtos.RefuseDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ButceTakipWebUI.Controllers
{
    public class RefuseController1 : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public RefuseController1(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public IActionResult CreateRefuse()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRefuse(CreateRefuseDto createRefuseDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createRefuseDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var responseMessage = await client.PostAsync("https://localhost:7044/api/Refuse", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("BudgetController1", "Index"); // Başarılı olursa ana sayfaya yönlendir
            }

            ModelState.AddModelError(string.Empty, "Reddetme bilgisi gönderilirken bir hata oluştu.");
            return View(createRefuseDto);
        }
    }
}
