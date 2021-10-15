using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace C_Presentacion.Controllers
{
    public class RegistroController : Controller
    {
        // GET: Registro
        public ActionResult Formulario()
        {
            return View();
        }
    }
}