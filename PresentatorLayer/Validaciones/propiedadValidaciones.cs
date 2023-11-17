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
    public class PropiedadesValidator : AbstractValidator<Propiedad>
    {
        public PropiedadesValidator()
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;

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

}

    
