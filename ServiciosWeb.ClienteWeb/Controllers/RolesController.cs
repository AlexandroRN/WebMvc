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
    public class RolesController : Controller
    {
        // GET: Roles
        public ActionResult Index()
        {
            HttpClient clientehttp = new HttpClient();
            clientehttp.BaseAddress = new Uri("https://localhost:44372/");

            var request = clientehttp.GetAsync("api/Roles").Result;

            if (request.IsSuccessStatusCode)
            {
                var resulString = request.Content.ReadAsStringAsync().Result;
                var listado = JsonConvert.DeserializeObject<List<Roles>>(resulString);

                return View(listado);
            }

            return View(new List<Roles>());
           
        }
    }
}