
namespace SolucionesRecidnciales.Domain.Entities
{
    public class Cotizaciones
    {
        public int IdCotizacion { get; set; }

        public int? IdCliente { get; set; }

        public int? IdEdificio { get; set; }

        public DateOnly? FechaCreacion { get; set; }

        public DateOnly? FechaVencimiento { get; set; }

        public string? Descripcion { get; set; }

        public decimal? Subtotal { get; set; }

        public decimal? Descuento { get; set; }

        public decimal? Impuestos { get; set; }

        public decimal? Total { get; set; }

        public string? Estado { get; set; }

        public string? TerminosCondiciones { get; set; }

        public string? Observaciones { get; set; }

        public virtual Cliente? IdClienteNavigation { get; set; }

        public virtual Edificio? IdEdificioNavigation { get; set; }
    }
}
