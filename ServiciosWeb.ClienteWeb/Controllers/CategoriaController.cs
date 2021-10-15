using Newtonsoft.Json;
using ServiciosWeb.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace ServiciosWeb.ClienteWeb.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult Index()
        {
            HttpClient clientehttp = new HttpClient();
            clientehttp.BaseAddress = new Uri("https://localhost:44372/");

            var request = clientehttp.GetAsync("api/Categoria").Result;

            if (request.IsSuccessStatusCode)
            {
                var resulString = request.Content.ReadAsStringAsync().Result;
                var listado = JsonConvert.DeserializeObject<List<Categoria>>(resulString);

                return View(listado);
            }

            return View(new List<Categoria>());
            
        }
    }
}