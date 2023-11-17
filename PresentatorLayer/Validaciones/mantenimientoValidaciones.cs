using CommonLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentatorLayer.Validaciones
{
   
     public class mantenimientoValidator : AbstractValidator<Mantenimiento>
    {
        public mantenimientoValidator()
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(mantenimiento => mantenimiento.descripcion)
                .NotEmpty().When(mantenimiento => string.IsNullOrEmpty(mantenimiento.descripcion))
                .WithMessage("La la descripción no puede estar vacía");


            RuleFor(mantenimiento => mantenimiento.costo)
                .NotEmpty().WithMessage("El costo  no puede estar vacío")
                .Matches(@"^\d+$").WithMessage("El costo debe tener solo números");
        }
    }
}
