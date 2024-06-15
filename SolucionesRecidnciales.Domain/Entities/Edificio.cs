namespace SolucionesRecidnciales.Domain.Entities
{
    public class Edificio
    {
        public int IdEdificio { get; set; }

        public int? IdCliente { get; set; }

        public string? NombreEdificio { get; set; }

        public string? Direccion { get; set; }

        public virtual ICollection<Cotizaciones> Cotizaciones { get; set; } = new List<Cotizaciones>();

        public virtual Cliente? IdClienteNavigation { get; set; }
    }
}
