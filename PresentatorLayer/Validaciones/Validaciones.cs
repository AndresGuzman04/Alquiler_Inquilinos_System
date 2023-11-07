using CommonLayer;
using CommonLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentatorLayer.Validaciones
{
    public class PropiedadesValidator: AbstractValidator<Propiedad>
    {
        public PropiedadesValidator()
        {
            RuleFor(propiedad => propiedad.Nombre)
                .NotEmpty().When(propiedad => string.IsNullOrEmpty(propiedad.Nombre))
                .WithMessage("El nombre no puede estar vacío");

            RuleFor(propiedad => propiedad.Direccion)
                .NotEmpty().When(propiedad => string.IsNullOrEmpty(propiedad.Direccion))
                .WithMessage("La dirección no puede estar vacía");

            RuleFor(propiedad => propiedad.TipoPropiedad)
                .NotEmpty().When(propiedad => string.IsNullOrEmpty(propiedad.TipoPropiedad))
                .WithMessage("El tipo de propiedad no puede estar vacío");

            RuleFor(propiedad => propiedad.PagoMensual)
            .NotEmpty().WithMessage("El pago mensual no puede estar vacío")
            .Matches(@"^\d+$").WithMessage("El pago mensual debe contener solo números");
        }

    }

    public class PagoValidator : AbstractValidator<Pago>
    {
        public PagoValidator()
        {


            RuleFor(pago => pago.monto)
        .NotEmpty().WithMessage("El pago mensual no puede estar vacío")
        .Matches(@"^\d+$").WithMessage("El monto debe tener solo numeros");

        }


    }

    public class MantenimientoValidator : AbstractValidator<Mantenimiento>
    {
        public MantenimientoValidator()
        {
            RuleFor(mantenimiento => mantenimiento.descripcion)
        .NotEmpty().When(mantenimiento => string.IsNullOrEmpty(mantenimiento.descripcion))
        .WithMessage("La la descripción no puede estar vacía");


            RuleFor(mantenimiento => mantenimiento.costo)
        .NotEmpty().WithMessage("El costo  no puede estar vacío")
        .Matches(@"^\d+$").WithMessage("El costo debe tener solo números");

        }


    }

    public class InquilinosValidator : AbstractValidator<Inquilino>
    {
        public InquilinosValidator()
        {
            RuleFor(Inquilino => Inquilino.Nombre)
        .NotEmpty().When(mantenimiento => string.IsNullOrEmpty(mantenimiento.Nombre))
        .WithMessage("La la descripción no puede estar vacía");
            RuleFor(Inquilino => Inquilino.Direccion)
        .NotEmpty().When(mantenimiento => string.IsNullOrEmpty(mantenimiento.Direccion))
        .WithMessage("La la descripción no puede estar vacía");
            RuleFor(Inquilino => Inquilino.Email)
        .NotEmpty().When(mantenimiento => string.IsNullOrEmpty(mantenimiento.Email))
        .WithMessage("La la descripción no puede estar vacía");
            RuleFor(Inquilino => Inquilino.Telefono)
        .NotEmpty().When(mantenimiento => string.IsNullOrEmpty(mantenimiento.Telefono))
        .WithMessage("La la descripción no puede estar vacía");


        }


    }
}
