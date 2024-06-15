using Microsoft.EntityFrameworkCore;
using SolucionesRecidencilaes.Application.Interfaces;
using SolucionesRecidnciales.Domain.Entities;
using System.Reflection;

namespace SolucionesRecidenciales.Infraestructure.Context
{
    public partial class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        protected ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }

        public virtual DbSet<Cotizaciones> Cotizaciones { get; set; }

        public virtual DbSet<CuentasBancarias> CuentasBancarias { get; set; }

        public virtual DbSet<Edificio> Edificios { get; set; }

        public virtual DbSet<Material> Materiales { get; set; }

        public virtual DbSet<Proveedor> Proveedores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            OnModelCreatingPartial(modelBuilder);
        }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return await base.SaveChangesAsync(cancellationToken);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);



    }
}
