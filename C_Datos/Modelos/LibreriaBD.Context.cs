﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace C_Datos.Modelos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LibreriaConetion : DbContext
    {
        public LibreriaConetion()
            : base("name=LibreriaConetion")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Solicitud> Solicitud { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Vacantes> Vacantes { get; set; }
    }
}
