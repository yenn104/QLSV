using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLSV.DataccessLayer
{
    public partial class QLSinhVienDBContext : DbContext
    {
        public QLSinhVienDBContext()
            : base("name=QLSinhVienDBContext")
        {
        }

        public virtual DbSet<Diem> Diems { get; set; }
        public virtual DbSet<LopHoc> LopHocs { get; set; }
        public virtual DbSet<MonHoc> MonHocs { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Diem>()
                .Property(e => e.MSSV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LopHoc>()
                .Property(e => e.MaLop)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LopHoc>()
                .HasMany(e => e.SinhViens)
                .WithOptional(e => e.LopHoc)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.MSSV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.MaLop)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
