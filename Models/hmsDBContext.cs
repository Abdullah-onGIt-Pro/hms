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
        public virtual DbSet<StateMaster> StateMaster { get; set; }
        public virtual DbSet<UserMaster> UserMaster { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=hmsDB;User Name=postgres;Password=postgres;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>(entity =>
            {
                entity.HasKey(e => e.BookingAutoId)
                    .HasName("Booking_pkey");

                entity.ToTable("Booking", "Common");

                entity.Property(e => e.AadharNumber).HasMaxLength(50);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.HmsTenantAutoId).HasColumnName("hmsTenantAutoId");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CityMaster>(entity =>
            {
                entity.HasKey(e => e.CityMasterAutoId)
                    .HasName("CityMaster_pkey");

                entity.ToTable("CityMaster", "Global");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<CountryMaster>(entity =>
            {
                entity.HasKey(e => e.CountryMasterAutoId)
                    .HasName("CountryMaster_pkey");

                entity.ToTable("CountryMaster", "Global");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Isocode)
                    .IsRequired()
                    .HasColumnName("ISOCode")
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<FloorMaster>(entity =>
            {
                entity.HasKey(e => e.FloorMasterAutoId)
                    .HasName("FloorMaster_pkey");

                entity.ToTable("FloorMaster", "Common");

                entity.Property(e => e.FloorName).HasMaxLength(50);

                entity.Property(e => e.HmsTenantAutoId).HasColumnName("hmsTenantAutoId");
            });
            
            modelBuilder.Entity<StateMaster>(entity =>
            {
                entity.HasKey(e => e.StateMasterAutoId)
                    .HasName("StateMaster_pkey");

                entity.ToTable("StateMaster", "Global");

                entity.Property(e => e.CountryMasterAutoId).HasDefaultValueSql("1");

                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasOne(d => d.CountryMasterAuto)
                    .WithMany(p => p.StateMaster)
                    .HasForeignKey(d => d.CountryMasterAutoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("StateMaster_CountryMasterAutoId_fkey");
            });

            modelBuilder.Entity<UserMaster>(entity =>
            {
                entity.HasKey(e => e.UserMasterAutoId)
                    .HasName("UserMaster_pkey");

                entity.ToTable("UserMaster", "Common");

                entity.Property(e => e.HmsTenantAutoId).HasColumnName("hmsTenantAutoId");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserId).HasMaxLength(10);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
