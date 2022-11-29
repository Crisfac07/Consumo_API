using APIBooks.Models;
using BooksMVC.Models;
using BooksMVC.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BooksMVC.Controllers
{
    public class HomeController : Controller
    {
        private static HttpClient client = new HttpClient();
        private readonly ILogger<HomeController> _logger;
        private readonly IServicio_API _servicio_API;

        public HomeController(ILogger<HomeController> logger, IServicio_API servicio_API)
        {
            _logger = logger;
            _servicio_API = servicio_API;
        }

        public async Task<IActionResult> Index()
        {
            //http://localhost:55843/api/Authors

           
            var json= await client.GetStringAsync("http://localhost:55843/api/Authors");
            var listAuthors = JsonConvert.DeserializeObject<List<Author>>(json);
            
            return View(listAuthors);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> CRUD()
        {
            var list = await _servicio_API.Listar();
            return View(list);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
