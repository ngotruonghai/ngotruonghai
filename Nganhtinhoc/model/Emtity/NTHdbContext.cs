namespace model.Emtity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NTHdbContext : DbContext
    {
        public NTHdbContext()
            : base("name=NTHdbContext")
        {
        }

        public virtual DbSet<Diemsinhvien> Diemsinhviens { get; set; }
        public virtual DbSet<Giaovien> Giaoviens { get; set; }
        public virtual DbSet<Nganh> Nganhs { get; set; }
        public virtual DbSet<Sinhvien> Sinhviens { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Taikhoan> Taikhoans { get; set; }
        public virtual DbSet<Tailieu> Tailieux { get; set; }
        public virtual DbSet<Thoikhoabieu> Thoikhoabieux { get; set; }
        public virtual DbSet<Thongbao> Thongbaos { get; set; }
        public virtual DbSet<Thongbaotruong> Thongbaotruongs { get; set; }
        public virtual DbSet<Tuyendung> Tuyendungs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Diemsinhvien>()
                .Property(e => e.masinhvien)
                .IsUnicode(false);

            modelBuilder.Entity<Giaovien>()
                .Property(e => e.magiaovien)
                .IsUnicode(false);

            modelBuilder.Entity<Giaovien>()
                .Property(e => e.manganh)
                .IsUnicode(false);

            modelBuilder.Entity<Nganh>()
                .Property(e => e.manganh)
                .IsUnicode(false);

            modelBuilder.Entity<Sinhvien>()
                .Property(e => e.masinhvien)
                .IsUnicode(false);

            modelBuilder.Entity<Sinhvien>()
                .Property(e => e.manganh)
                .IsUnicode(false);

            modelBuilder.Entity<Tailieu>()
                .Property(e => e.magiaovien)
                .IsUnicode(false);

            modelBuilder.Entity<Thoikhoabieu>()
                .Property(e => e.manganh)
                .IsUnicode(false);
        }
    }
}
