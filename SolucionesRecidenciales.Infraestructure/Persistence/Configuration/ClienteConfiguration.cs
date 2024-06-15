

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolucionesRecidnciales.Domain.Entities;

namespace SolucionesRecidenciales.Infraestructure.Persistence.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(e => e.IdCliente).HasName("PK__Clientes__677F38F5428C1CB4");

            builder.Property(e => e.IdCliente).HasColumnName("id_cliente");
            builder.Property(e => e.Direccion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("direccion");
            builder.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            builder.Property(e => e.NitOCc).HasColumnName("nit_o_cc");
            builder.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            builder.Property(e => e.Telefono).HasColumnName("telefono");
        }
    }
}
