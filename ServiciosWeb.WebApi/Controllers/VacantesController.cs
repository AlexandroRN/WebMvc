using C_Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServiciosWeb.WebApi.Controllers
{
    public class VacantesController : ApiController
    {
        LibreriaConetion BD = new LibreriaConetion();
        [HttpGet]
        public IEnumerable<Vacantes> GetVacantes()
        {
            var Listado = BD.Vacantes.ToList();
            return Listado;
        }

        [HttpGet]
        public Vacantes GetVacantes(int id)
        {
            var Vacants = BD.Vacantes.FirstOrDefault(x => x.IdVacante == id);
            return Vacants;
        }

        [HttpPost]
        public bool Post(Vacantes vacantes)
        {
            BD.Vacantes.Add(vacantes);
            return BD.SaveChanges() > 0;
        }

        [HttpPut]
        public bool Put(Vacantes vacantes)
        {
            var VacantesActualizar = BD.Vacantes.FirstOrDefault(x => x.IdVacante == vacantes.IdVacante);

            VacantesActualizar.idcategoria = vacantes.idcategoria;
            VacantesActualizar.Empresa = vacantes.Empresa;
            VacantesActualizar.Posicion = vacantes.Posicion;
            VacantesActualizar.Descripcion = vacantes.Descripcion;
            VacantesActualizar.Horario = vacantes.Horario;
            VacantesActualizar.Ubicacion = vacantes.Ubicacion;

            return BD.SaveChanges() > 0;
        }

        [HttpDelete]
        public bool Delete(int IdVacante)
        {
            var VacantesEliminar = BD.Vacantes.FirstOrDefault(x => x.IdVacante == IdVacante);
            BD.Vacantes.Remove(VacantesEliminar);
            return BD.SaveChanges() > 0;
        }

    }
}
