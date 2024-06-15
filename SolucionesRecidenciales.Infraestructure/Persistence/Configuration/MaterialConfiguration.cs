

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolucionesRecidnciales.Domain.Entities;

namespace SolucionesRecidenciales.Infraestructure.Persistence.Configuration
{
    public class MaterialConfiguration : IEntityTypeConfiguration<Material>
    {
        public void Configure(EntityTypeBuilder<Material> builder)
        {
            builder.HasKey(e => e.IdMaterial).HasName("PK__Material__81E99B839316F04F");

            builder.Property(e => e.IdMaterial).HasColumnName("id_material");
            builder.Property(e => e.Cantidad).HasColumnName("cantidad");
            builder.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            builder.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            builder.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            builder.Property(e => e.PrecioUnitario)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio_unitario");

            builder.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.Materiales)
                .HasForeignKey(d => d.IdProveedor)
                .HasConstraintName("FK__Materiale__id_pr__3E52440B");
        }
    }
}
