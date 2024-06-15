namespace SolucionesRecidnciales.Domain.Entities
{
    public class CuentasBancarias
    {
        public int IdCuenta { get; set; }

        public int? IdCliente { get; set; }

        public int? IdProveedor { get; set; }

        public string? NumeroCuenta { get; set; }

        public string? Banco { get; set; }

        public string? TipoCuenta { get; set; }

        public virtual Cliente? IdClienteNavigation { get; set; }

        public virtual Proveedor? IdProveedorNavigation { get; set; }
    }
}
