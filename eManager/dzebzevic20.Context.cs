﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eManager
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dzebcevic20_DBEntities1 : DbContext
    {
        public dzebcevic20_DBEntities1()
            : base("name=dzebcevic20_DBEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Korisnik> Korisniks { get; set; }
        public virtual DbSet<Oprema> Opremas { get; set; }
        public virtual DbSet<Rezervacija> Rezervacijas { get; set; }
    }
}