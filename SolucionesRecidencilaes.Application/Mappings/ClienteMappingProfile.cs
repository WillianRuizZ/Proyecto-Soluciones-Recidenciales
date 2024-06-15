using AutoMapper;
using SolucionesRecidencilaes.Application.Dtos;
using SolucionesRecidnciales.Domain.Entities;

namespace SolucionesRecidencilaes.Application.Mappings
{
    public class ClienteMappingProfile : Profile
    {
        public ClienteMappingProfile()
        {
            CreateMap<Cliente, ClienteDto>();
            CreateMap<ClienteDto, Cliente>();

        }
    }
}
