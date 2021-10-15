using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using C_Datos;
using C_Datos.Modelos;

namespace ServiciosWeb.WebApi.Controllers
{
    public class CategoriaController : ApiController
    {
        LibreriaConetion BD = new LibreriaConetion();

        [HttpGet]
        public IEnumerable<Categoria> GetCategorias()
        {
            var Listado = BD.Categoria.ToList();
            return Listado;
        }

        [HttpGet]
        public Categoria GetCategorias(int id)
        {
            var Category = BD.Categoria.FirstOrDefault(x=> x.IdCategoria == id);
            return Category;
        }

        [HttpPost]
        public bool Post(Categoria categoria)
        {
            BD.Categoria.Add(categoria);
            return BD.SaveChanges() > 0;
        }

        [HttpPut]
        public bool Put(Categoria categoria)
        {
            var CategoriaActualizar = BD.Categoria.FirstOrDefault(x => x.IdCategoria == categoria.IdCategoria);
            
            CategoriaActualizar.NombreCategoria = categoria.NombreCategoria;

            
            return BD.SaveChanges() > 0;
        }

        [HttpDelete]
        public bool Delete(int IdCategoria)
        {
            var CategoriaEliminar = BD.Categoria.FirstOrDefault(x => x.IdCategoria == IdCategoria);
            BD.Categoria.Remove(CategoriaEliminar);
            return BD.SaveChanges() >0;
        }
    }
}
