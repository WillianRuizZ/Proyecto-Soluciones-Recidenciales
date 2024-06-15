
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolucionesRecidnciales.Domain.Entities;

namespace SolucionesRecidenciales.Infraestructure.Persistence.Configuration
{
    internal class CotizacionConfiguration : IEntityTypeConfiguration<Cotizaciones>
    {
        public void Configure(EntityTypeBuilder<Cotizaciones> builder)
        {
            builder.HasKey(e => e.IdCotizacion).HasName("PK__Cotizaci__9713D1746B0FD6A1");

            builder.Property(e => e.IdCotizacion).HasColumnName("id_cotizacion");
            builder.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            builder.Property(e => e.Descuento)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("descuento");
            builder.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado");
            builder.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");
            builder.Property(e => e.FechaVencimiento).HasColumnName("fecha_vencimiento");
            builder.Property(e => e.IdCliente).HasColumnName("id_cliente");
            builder.Property(e => e.IdEdificio).HasColumnName("id_edificio");
            builder.Property(e => e.Impuestos)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("impuestos");
            builder.Property(e => e.Observaciones)
                .HasColumnType("text")
                .HasColumnName("observaciones");
            builder.Property(e => e.Subtotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("subtotal");
            builder.Property(e => e.TerminosCondiciones)
                .HasColumnType("text")
                .HasColumnName("terminos_condiciones");
            builder.Property(e => e.Total)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("total");

            builder.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Cotizaciones)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("FK__Cotizacio__id_cl__44FF419A");

            builder.HasOne(d => d.IdEdificioNavigation).WithMany(p => p.Cotizaciones)
                .HasForeignKey(d => d.IdEdificio)
                .HasConstraintName("FK__Cotizacio__id_ed__45F365D3");
        }
    }
}
