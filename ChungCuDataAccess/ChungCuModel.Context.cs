﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChungCuDataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ChungCuEntities2 : DbContext
    {
        public ChungCuEntities2()
            : base("name=ChungCuEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CanHo> CanHos { get; set; }
        public virtual DbSet<CSVC> CSVCs { get; set; }
        public virtual DbSet<CuDan> CuDans { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}