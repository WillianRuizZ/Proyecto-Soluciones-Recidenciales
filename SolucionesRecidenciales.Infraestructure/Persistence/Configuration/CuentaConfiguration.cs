
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolucionesRecidnciales.Domain.Entities;

namespace SolucionesRecidenciales.Infraestructure.Persistence.Configuration
{
    public class CuentaConfiguration : IEntityTypeConfiguration<CuentasBancarias>
    {
        public void Configure(EntityTypeBuilder<CuentasBancarias> builder)
        {
            builder.HasKey(e => e.IdCuenta).HasName("PK__CuentasB__C7E28685DEC38C88");

            builder.Property(e => e.IdCuenta).HasColumnName("id_cuenta");
            builder.Property(e => e.Banco)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("banco");
            builder.Property(e => e.IdCliente).HasColumnName("id_cliente");
            builder.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            builder.Property(e => e.NumeroCuenta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numero_cuenta");
            builder.Property(e => e.TipoCuenta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo_cuenta");

            builder.HasOne(d => d.IdClienteNavigation).WithMany(p => p.CuentasBancaria)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("FK__CuentasBa__id_cl__412EB0B6");

            builder.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.CuentasBancarias)
                .HasForeignKey(d => d.IdProveedor)
                .HasConstraintName("FK__CuentasBa__id_pr__4222D4EF");
        }
    }
}
