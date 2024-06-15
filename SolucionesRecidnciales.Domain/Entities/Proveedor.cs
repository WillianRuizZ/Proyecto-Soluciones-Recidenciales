namespace SolucionesRecidnciales.Domain.Entities
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }

        public string? NitOCc { get; set; }

        public string? Nombre { get; set; }

        public string? Direccion { get; set; }

        public string? Telefono { get; set; }

        public string? Email { get; set; }

        public virtual ICollection<CuentasBancarias> CuentasBancarias { get; set; } = new List<CuentasBancarias>();

        public virtual ICollection<Material> Materiales { get; set; } = new List<Material>();
    }
}
