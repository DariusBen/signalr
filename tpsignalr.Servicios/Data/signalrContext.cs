using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using tpsignalr.Modelos;

#nullable disable

namespace tpsignalr.Servicios.Data
{
    public partial class signalrContext : DbContext
    {
        public signalrContext()
        {
        }

        public signalrContext(DbContextOptions<signalrContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Sala> Salas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AI");

            modelBuilder.Entity<Sala>(entity =>
            {
                entity.ToTable("sala");

                entity.Property(e => e.FechaAlta)
                    .HasMaxLength(10)
                    .HasColumnName("fechaAlta")
                    .IsFixedLength(true);

                entity.Property(e => e.Imagen).HasMaxLength(1000);

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
