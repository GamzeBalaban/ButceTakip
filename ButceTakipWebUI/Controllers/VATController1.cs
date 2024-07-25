using ButceTakipWebUI.Dtos.VATDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace ButceTakipWebUI.Controllers
{
    public class VATController1 : Controller
    {
      
            private readonly IHttpClientFactory _httpClientFactory;

            public VATController1(IHttpClientFactory httpClientFactory)
            {
                _httpClientFactory = httpClientFactory;
            }

            public async Task<IActionResult> Index()
            {
                var client = _httpClientFactory.CreateClient();
                var responseMessage = await client.GetAsync("https://localhost:7044/api/VAT");
                if (responseMessage.IsSuccessStatusCode)
                {
                    var jsonData = await responseMessage.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<List<ResultVATDto>>(jsonData);
                    return View(values);
                }
                else
                {
                    return View(new List<ResultVATDto>()); // Boş bir liste döndür
                }
            }



            [HttpGet]
            public IActionResult CreateVAT()
            {
                return View();
            }

            [HttpPost]
            public async Task<IActionResult> CreateVAT(CreateVATDto createVATDto)
            {
           
                var client = _httpClientFactory.CreateClient();
                var jsonData = JsonConvert.SerializeObject(createVATDto);
                StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var responseMessage = await client.PostAsync("https://localhost:7044/api/VAT/", stringContent);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                return View();
            }

            public async Task<IActionResult> DeleteVAT(int id)
            {
                var client = _httpClientFactory.CreateClient();
                var responseMessage = await client.DeleteAsync($"https://localhost:7044/api/VAT/{id}");
                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                return View();
            }
      

        public async Task<IActionResult> UpdateVAT(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7044/api/VAT/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateVATDto>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateVAT(UpdateVATDto updateVATDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateVATDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7044/api/VAT/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();

        }
    }



}
  

