using CommonLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentatorLayer.Validaciones
{
    public class inquilinosValidator : AbstractValidator<Inquilino>
    {
        public inquilinosValidator()
        {
            CascadeMode = CascadeMode.Continue;



            RuleFor(Inquilino => Inquilino.Nombre)

                .NotEmpty().When(mantenimiento => string.IsNullOrEmpty(mantenimiento.Nombre))
                .WithMessage("el nombre no puede estar vacía");

            RuleFor(Inquilino => Inquilino.Direccion)
            .NotEmpty().When(mantenimiento => string.IsNullOrEmpty(mantenimiento.Direccion))
            .WithMessage("la direccion no puede estar vacía");


            RuleFor(inquilino => inquilino.Email)
            .NotEmpty().When(inq => string.IsNullOrEmpty(inq.Email))
            .WithMessage("El correo electrónico no puede estar vacío")
            .EmailAddress().WithMessage("Formato de correo electrónico no válido");

            RuleFor(inquilino => inquilino.Telefono)
            .NotEmpty().When(inq => string.IsNullOrEmpty(inq.Telefono))
            .WithMessage("El teléfono no puede estar vacío")
            .Matches(@"^\d{4}\d{4}$").WithMessage("Formato de teléfono no válido. Utiliza el formato (XXXXXXXX) 8 digitos.");
        }
    }
}