﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace is_takip_proje.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbisTakipEntities : DbContext
    {
        public DbisTakipEntities()
            : base("name=DbisTakipEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_admin> tbl_admin { get; set; }
        public virtual DbSet<tbl_departmanlar> tbl_departmanlar { get; set; }
        public virtual DbSet<tbl_firmalar> tbl_firmalar { get; set; }
        public virtual DbSet<tbl_gorev_detaylar> tbl_gorev_detaylar { get; set; }
        public virtual DbSet<tbl_gorevler> tbl_gorevler { get; set; }
        public virtual DbSet<tbl_personel> tbl_personel { get; set; }
    }
}