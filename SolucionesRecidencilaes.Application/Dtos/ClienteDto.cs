

namespace SolucionesRecidencilaes.Application.Dtos
{
    public class ClienteDto
    {
        public int IdCliente { get; set; }

        public string? Nombre { get; set; } = null!;

        public int NitOCc { get; set; }

        public string? Direccion { get; set; } = null!;

        public int Telefono { get; set; }

        public string? Email { get; set; } = null!;
    }
}
