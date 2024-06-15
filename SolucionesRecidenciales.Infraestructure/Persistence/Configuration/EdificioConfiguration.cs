
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolucionesRecidnciales.Domain.Entities;

namespace SolucionesRecidenciales.Infraestructure.Persistence.Configuration
{
    public class EdificioConfiguration : IEntityTypeConfiguration<Edificio>
    {
        public void Configure(EntityTypeBuilder<Edificio> builder)
        {
            builder.HasKey(e => e.IdEdificio).HasName("PK__Edificio__7298C2CFC23B73BC");

            builder.Property(e => e.IdEdificio).HasColumnName("id_edificio");
            builder.Property(e => e.Direccion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("direccion");
            builder.Property(e => e.IdCliente).HasColumnName("id_cliente");
            builder.Property(e => e.NombreEdificio)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_edificio");

            builder.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Edificios)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("FK__Edificios__id_cl__398D8EEE");
        }
    }
}
