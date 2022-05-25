using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace APICall.Models
{
    public partial class CityDataContext : DbContext
    {
        public CityDataContext()
        {
        }

        public CityDataContext(DbContextOptions<CityDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<City> City { get; set; }

        // Unable to generate entity type for table 'dbo.Test_Table'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=CityData;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.CityId).HasColumnName("City_Id");

                entity.Property(e => e.AreaSqKm).HasColumnName("Area_SqKm");

                entity.Property(e => e.City1)
                    .HasColumnName("City")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CricketStadium)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });
        }
    }
}
