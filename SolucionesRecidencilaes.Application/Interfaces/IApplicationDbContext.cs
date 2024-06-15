using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using SolucionesRecidnciales.Domain.Entities;

namespace SolucionesRecidencilaes.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Cliente> Clientes { get; set; }

        DbSet<Cotizaciones> Cotizaciones { get; set; }

        DbSet<CuentasBancarias> CuentasBancarias { get; set; }

        DbSet<Edificio> Edificios { get; set; }

        DbSet<Material> Materiales { get; set; }

        DbSet<Proveedor> Proveedores { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        DatabaseFacade Database { get; }

    }
}
