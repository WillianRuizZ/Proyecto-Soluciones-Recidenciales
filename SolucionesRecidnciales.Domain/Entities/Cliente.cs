namespace SolucionesRecidnciales.Domain.Entities
{
    public class Cliente
    {
        public int IdCliente { get; set; }

        public string? Nombre { get; set; } = null!;

        public int NitOCc { get; set; }

        public string? Direccion { get; set; } = null!;

        public int Telefono { get; set; }

        public string? Email { get; set; } = null!;


        public virtual ICollection<Cotizaciones> Cotizaciones { get; set; } = new List<Cotizaciones>();

        public virtual ICollection<CuentasBancarias> CuentasBancaria { get; set; } = new List<CuentasBancarias>();

        public virtual ICollection<Edificio> Edificios { get; set; } = new List<Edificio>();
    }
}
