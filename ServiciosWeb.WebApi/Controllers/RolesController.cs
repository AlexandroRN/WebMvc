using C_Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServiciosWeb.WebApi.Controllers
{
    public class RolesController : ApiController
    {
        LibreriaConetion BD = new LibreriaConetion();
        [HttpGet]
        public IEnumerable<Roles> GetRoles()
        {
            var Listado = BD.Roles.ToList();
            return Listado;
        }

        [HttpGet]
        public Roles GetRoles(int id)
        {
            var Rol = BD.Roles.FirstOrDefault(x => x.IDRol == id);
            return Rol;
        }

        [HttpPost]
        public bool Post(Roles roles)
        {
            BD.Roles.Add(roles);
            return BD.SaveChanges() > 0;
        }

        [HttpPut]
        public bool Put(Roles roles)
        {
            var RolesActualizar = BD.Roles.FirstOrDefault(x => x.IDRol == roles.IDRol);

            RolesActualizar.Tipo = roles.Tipo;
           
            return BD.SaveChanges() > 0;
        }

        [HttpDelete]
        public bool Delete(int IDRol)
        {
            var RolesEliminar = BD.Roles.FirstOrDefault(x => x.IDRol == IDRol);
            BD.Roles.Remove(RolesEliminar);
            return BD.SaveChanges() > 0;
        }
    }
}
