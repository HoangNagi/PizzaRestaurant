namespace PizzaRestaurant.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PizzaRestaurantModel : DbContext
    {
        public PizzaRestaurantModel()
            : base("name=PizzaRestaurantEntities")
        {
        }

        public virtual DbSet<BANAN> BANANs { get; set; }
        public virtual DbSet<CHITIETPHIEU> CHITIETPHIEUx { get; set; }
        public virtual DbSet<CHUCVU> CHUCVUs { get; set; }
        public virtual DbSet<DANHMUCBANAN> DANHMUCBANANs { get; set; }
        public virtual DbSet<DANHMUCMONAN> DANHMUCMONANs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<LUONG> LUONGs { get; set; }
        public virtual DbSet<MONAN> MONANs { get; set; }
        public virtual DbSet<NGUOIDUNG> NGUOIDUNGs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHIEUDATCHO> PHIEUDATCHOes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TINHTRANGPHIEU> TINHTRANGPHIEUx { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BANAN>()
                .Property(e => e.Anh)
                .IsUnicode(false);

            modelBuilder.Entity<BANAN>()
                .HasMany(e => e.PHIEUDATCHOes)
                .WithRequired(e => e.BANAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHUCVU>()
                .HasMany(e => e.NHANVIENs)
                .WithRequired(e => e.CHUCVU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DANHMUCMONAN>()
                .HasMany(e => e.MONANs)
                .WithRequired(e => e.DANHMUCMONAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.PHIEUDATCHOes)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LUONG>()
                .HasMany(e => e.NHANVIENs)
                .WithRequired(e => e.LUONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MONAN>()
                .Property(e => e.Anh)
                .IsUnicode(false);

            modelBuilder.Entity<MONAN>()
                .HasMany(e => e.CHITIETPHIEUx)
                .WithRequired(e => e.MONAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NGUOIDUNG>()
                .Property(e => e.TenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOIDUNG>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOIDUNG>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOIDUNG>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOIDUNG>()
                .Property(e => e.Anh)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.Anh)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.NGUOIDUNGs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.PHIEUDATCHOes)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUDATCHO>()
                .HasMany(e => e.CHITIETPHIEUx)
                .WithRequired(e => e.PHIEUDATCHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TINHTRANGPHIEU>()
                .HasMany(e => e.PHIEUDATCHOes)
                .WithRequired(e => e.TINHTRANGPHIEU)
                .WillCascadeOnDelete(false);
        }
    }
}
