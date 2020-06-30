using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace hms.Models
{
    public partial class hmsDBContext : DbContext
    {
        public hmsDBContext()
        {
        }

        public hmsDBContext(DbContextOptions<hmsDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<CityMaster> CityMaster { get; set; }
        public virtual DbSet<CountryMaster> CountryMaster { get; set; }
        public virtual DbSet<FloorMaster> FloorMaster { get; set; }
        public virtual DbSet<RoomMaster> RoomMaster { get; set; }
        public virtual DbSet<StateMaster> StateMaster { get; set; }
        public virtual DbSet<UserMaster> UserMaster { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=hmsDB;User Id=SA;Password=VoidMain@12;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>(entity =>
            {
                entity.HasKey(e => e.BookingAutoId)
                    .HasName("PK__Booking__8A11D33AC5E73D4B");

                entity.Property(e => e.AadharNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BookingDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeleteFlag)
                    .IsRequired()
                    .HasDefaultValueSql("('false')");

                entity.Property(e => e.HmsTenantAutoId).HasColumnName("hmsTenantAutoId");

                entity.Property(e => e.IsAcRequired)
                    .IsRequired()
                    .HasDefaultValueSql("('FALSE')");

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CityMaster>(entity =>
            {
                entity.HasKey(e => e.CityMasterAutoId)
                    .HasName("PK__CityMast__BF8F26B6889F29FE");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CountryMaster>(entity =>
            {
                entity.HasKey(e => e.CountryMasterAutoId)
                    .HasName("PK__CountryM__B01689D3E939BB24");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Isocode)
                    .IsRequired()
                    .HasColumnName("ISOCode")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FloorMaster>(entity =>
            {
                entity.HasKey(e => e.FloorMasterAutoId)
                    .HasName("PK__FloorMas__A06EB60D2B85C833");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteFlag)
                    .IsRequired()
                    .HasDefaultValueSql("('false')");

                entity.Property(e => e.FloorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HmsTenantAutoId).HasColumnName("hmsTenantAutoId");

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<RoomMaster>(entity =>
            {
                entity.HasKey(e => e.RoomMasterAutoId)
                    .HasName("PK__RoomMast__33BE31D8CB5AA2AC");

                entity.Property(e => e.BathRoomType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BedType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsAc)
                    .IsRequired()
                    .HasColumnName("IsAC")
                    .HasDefaultValueSql("('false')");

                entity.Property(e => e.IsBathRoomAttached)
                    .IsRequired()
                    .HasDefaultValueSql("('true')");

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RoomNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StateMaster>(entity =>
            {
                entity.HasKey(e => e.StateMasterAutoId)
                    .HasName("PK__StateMas__C83BC0A6D1E7881C");

                entity.Property(e => e.CountryMasterAutoId).HasDefaultValueSql("((1))");

                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserMaster>(entity =>
            {
                entity.HasKey(e => e.UserMasterAutoId)
                    .HasName("PK__UserMast__DE575AACE0FEA893");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteFlag)
                    .IsRequired()
                    .HasDefaultValueSql("('false')");

                entity.Property(e => e.EmailId).HasColumnType("text");

                entity.Property(e => e.HmsTenantAutoId).HasColumnName("hmsTenantAutoId");

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber).HasColumnType("text");

                entity.Property(e => e.UserId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
