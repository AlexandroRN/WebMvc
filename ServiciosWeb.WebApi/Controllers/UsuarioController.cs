using C_Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServiciosWeb.WebApi.Controllers
{
    public class UsuarioController : ApiController
    {
        LibreriaConetion BD = new LibreriaConetion();
        [HttpGet]
        public IEnumerable<Usuario> GetUsuarios()
        {
            var Listado = BD.Usuario.ToList();
            return Listado;
        }

        [HttpGet]
        public Usuario GetUsuarios(int id)
        {
            var User = BD.Usuario.FirstOrDefault(x => x.IdUsuario == id);
            return User;
        }

        [HttpPost]
        public bool Post(Usuario usuario)
        {
            BD.Usuario.Add(usuario);
            return BD.SaveChanges() > 0;
        }

        [HttpPut]
        public bool Put(Usuario usuario)
        {
            var UsuarioActualizar = BD.Usuario.FirstOrDefault(x => x.IdUsuario == usuario.IdUsuario);

            UsuarioActualizar.Nombre = usuario.Nombre;
            UsuarioActualizar.Apellido = usuario.Apellido;
            UsuarioActualizar.Correo = usuario.Correo;
            UsuarioActualizar.idRol = usuario.idRol;
            UsuarioActualizar.Cedula = usuario.Cedula;
            UsuarioActualizar.Telefono = usuario.Telefono;

            return BD.SaveChanges() > 0;
        }

        [HttpDelete]
        public bool Delete(int IdUsuario)
        {
            var UsuarioEliminar = BD.Usuario.FirstOrDefault(x => x.IdUsuario == IdUsuario);
            BD.Usuario.Remove(UsuarioEliminar);
            return BD.SaveChanges() > 0;
        }
    }
}
