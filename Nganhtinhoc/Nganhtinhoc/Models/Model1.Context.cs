﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nganhtinhoc.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NTHEntities : DbContext
    {
        public NTHEntities()
            : base("name=NTHEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Diemsinhvien> Diemsinhvien { get; set; }
        public virtual DbSet<Giaovien> Giaovien { get; set; }
        public virtual DbSet<Nganh> Nganh { get; set; }
        public virtual DbSet<Sinhvien> Sinhvien { get; set; }
        public virtual DbSet<Taikhoan> Taikhoan { get; set; }
        public virtual DbSet<Tailieu> Tailieu { get; set; }
        public virtual DbSet<Tuyendung> Tuyendung { get; set; }
        public virtual DbSet<Thoikhoabieu> Thoikhoabieu { get; set; }
        public virtual DbSet<Thongbao> Thongbao { get; set; }
        public virtual DbSet<Thongbaotruong> Thongbaotruong { get; set; }

        public System.Data.Entity.DbSet<model.Emtity.Thongbao> Thongbaos { get; set; }
    }
}
