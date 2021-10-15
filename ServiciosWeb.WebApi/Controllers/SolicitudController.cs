using C_Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServiciosWeb.WebApi.Controllers
{
    public class SolicitudController : ApiController
    {
        LibreriaConetion BD = new LibreriaConetion();
        [HttpGet]
        public IEnumerable<Solicitud> GetSolicituds()
        {
            var Listado = BD.Solicitud.ToList();
            return Listado;
        }

        [HttpGet]
        public Solicitud GetSolicituds(int id)
        {
            var Soli = BD.Solicitud.FirstOrDefault(x => x.IdSolicitud == id);
            return Soli;
        }

        [HttpPost]
        public bool Post(Solicitud solicitud)
        {
            BD.Solicitud.Add(solicitud);
            return BD.SaveChanges() > 0;
        }

        [HttpPut]
        public bool Put(Solicitud solicitud)
        {
            var SolicitudActualizar = BD.Solicitud.FirstOrDefault(x => x.IdSolicitud == solicitud.IdSolicitud);

            SolicitudActualizar.idusuario = solicitud.idusuario;
            SolicitudActualizar.idvacante = solicitud.idvacante;

            return BD.SaveChanges() > 0;
        }

        [HttpDelete]
        public bool Delete(int IdSolicitud)
        {
            var SolicitudEliminar = BD.Solicitud.FirstOrDefault(x => x.IdSolicitud == IdSolicitud);
            BD.Solicitud.Remove(SolicitudEliminar);
            return BD.SaveChanges() > 0;
        }
    }
}
