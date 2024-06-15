

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolucionesRecidnciales.Domain.Entities;

namespace SolucionesRecidenciales.Infraestructure.Persistence.Configuration
{
    public class ProveedorConfiguration : IEntityTypeConfiguration<Proveedor>
    {
        public void Configure(EntityTypeBuilder<Proveedor> builder)
        {
            builder.HasKey(e => e.IdProveedor).HasName("PK__Proveedo__8D3DFE286A794406");

            builder.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            builder.Property(e => e.Direccion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("direccion");
            builder.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            builder.Property(e => e.NitOCc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nit_o_cc");
            builder.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            builder.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefono");
        }
    }
}
