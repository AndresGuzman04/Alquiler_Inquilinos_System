using CommonLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentatorLayer.Validaciones
{
    public class PagoValidator : AbstractValidator<Pago>
    {
        public PagoValidator()
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(pago => pago.monto)
                .NotEmpty().WithMessage("El pago mensual no puede estar vacío")
                .Matches(@"^\d+$").WithMessage("El monto debe tener solo numeros");

        }
    }
}