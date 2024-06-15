

using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Logging;
using SolucionesRecidencilaes.Application.Interfaces;
using SolucionesRecidnciales.Domain.Entities;

namespace SolucionesRecidencilaes.Application.Queries
{
    public class CreateClienteCommand : IRequest<int>
    {

        public string? Nombre { get; set; } = null!;

        public int NitOCc { get; set; }

        public string? Direccion { get; set; } = null!;

        public int Telefono { get; set; }

        public string? Email { get; set; } = null!;

        public class Validator : AbstractValidator<CreateClienteCommand>
        {
            public Validator()
            {
                RuleFor(command => command.Nombre)
                    .NotEmpty()
                    .WithMessage("El nombre es requerido.");

                RuleFor(command => command.NitOCc)
                    .NotEmpty()
                    .WithMessage("El NIT o CC es requerido.")
                    .Must(nit => nit >= 0)
                    .WithMessage("El NIT o CC debe ser un número positivo.");

                RuleFor(command => command.Direccion)
                    .NotEmpty()
                    .WithMessage("La dirección es requerida.");

                RuleFor(command => command.Telefono)
               .NotEmpty()
               .Must(t => t.ToString().Length >= 7 && t.ToString().Length <= 14)
               .WithMessage("El teléfono debe tener entre 7 y 14 dígitos.");

                RuleFor(command => command.Email)
                    .NotEmpty()
                    .EmailAddress()
                    .WithMessage("El email debe ser válido.");
            }
        }

        public class Handler : IRequestHandler<CreateClienteCommand, int>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;
            private readonly ILogger<CreateClienteCommand> _logger;
            private readonly IMediator _mediator;

            public Handler(IApplicationDbContext context, IMapper mapper, ILogger<CreateClienteCommand> logger, IMediator mediator)
            {
                _context = context;
                _mapper = mapper;
                _logger = logger;
                _mediator = mediator;
            }

            public async Task<int> Handle(CreateClienteCommand request, CancellationToken cancellationToken)
            {
                // Validar el comando
                var validator = new Validator();
                var validationResult = await validator.ValidateAsync(request, cancellationToken);

                if (!validationResult.IsValid)
                {
                    // Si hay errores de validación, lanzar una excepción o manejar los errores de alguna manera
                    throw new ValidationException(validationResult.Errors);
                }

                // Si la validación es exitosa, continuar con la creación del cliente
                var cliente = new Cliente
                {
                    Nombre = request.Nombre,
                    NitOCc = request.NitOCc,
                    Direccion = request.Direccion,
                    Telefono = request.Telefono,
                    Email = request.Email
                };

                _context.Clientes.Add(cliente);
                await _context.SaveChangesAsync(cancellationToken);
                return cliente.IdCliente;
            }
        }
    }
}
