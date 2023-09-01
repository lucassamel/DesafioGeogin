using DesafioGeogin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text;

namespace DesafioGeogin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }  

        public IActionResult Index()
        {
            
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetCaixaEletronico()
        {
            CaixaEletronico caixaEletronico = new CaixaEletronico();
            //HttpResponseMessage response = new HttpResponseMessage();
            using (var httpClient = new HttpClient())
            {
                using ( var response = await httpClient.GetAsync("http://localhost:26447/api/Saque"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    caixaEletronico = JsonConvert.DeserializeObject<CaixaEletronico>(apiResponse)!;

                }
            }

            return Ok(caixaEletronico);
        }
        
        [HttpPost]
        public async Task<IActionResult> PostCaixaEletronico(int saque)
        {       
            CaixaEletronico cx = new CaixaEletronico();            
            using (var httpClient = new HttpClient())
            {            
                StringContent content = new StringContent(JsonConvert.SerializeObject(saque), Encoding.UTF8, "application/json");

                try
                {
                    using (var response = await httpClient.PostAsync("http://localhost:26447/api/Saque", content))
                    {
                        if (!response.IsSuccessStatusCode)
                        {
                            throw new HttpRequestException(await response.Content.ReadAsStringAsync());
                        }

                        string apiResponse = await response.Content.ReadAsStringAsync();                     
                        cx = JsonConvert.DeserializeObject<CaixaEletronico>(apiResponse)!;
                    }

                 return Ok(cx);
                }
                catch (HttpRequestException ex)
                {
                    return BadRequest(ex.Message);
                }                             
                
            }
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}