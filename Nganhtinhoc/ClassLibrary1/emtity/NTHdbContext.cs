namespace ClassLibrary1.emtity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NTHdbContext : DbContext
    {
        public NTHdbContext()
            : base("name=NTHdbContext1")
        {
        }

        public virtual DbSet<Diemsinhvien> Diemsinhvien { get; set; }
        public virtual DbSet<Giaovien> Giaovien { get; set; }
        public virtual DbSet<Nganh> Nganh { get; set; }
        public virtual DbSet<Sinhvien> Sinhvien { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Taikhoan> Taikhoan { get; set; }
        public virtual DbSet<Tailieu> Tailieu { get; set; }
        public virtual DbSet<Tuyendung> Tuyendung { get; set; }
        public virtual DbSet<Thoikhoabieu> Thoikhoabieu { get; set; }
        public virtual DbSet<Thongbao> Thongbao { get; set; }
        public virtual DbSet<Thongbaotruong> Thongbaotruong { get; set; }

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
