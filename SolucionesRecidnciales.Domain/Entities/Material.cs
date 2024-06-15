namespace SolucionesRecidnciales.Domain.Entities
{
    public class Material
    {
        public int IdMaterial { get; set; }

        public int? IdProveedor { get; set; }

        public string? Nombre { get; set; }

        public string? Descripcion { get; set; }

        public int? Cantidad { get; set; }

        public decimal? PrecioUnitario { get; set; }

        public virtual Proveedor? IdProveedorNavigation { get; set; }
    }
}
