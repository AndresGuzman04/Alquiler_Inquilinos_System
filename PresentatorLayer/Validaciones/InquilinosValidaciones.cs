﻿using CommonLayer.Entities;
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
            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(Inquilino => Inquilino.Nombre)
                .NotEmpty().When(mantenimiento => string.IsNullOrEmpty(mantenimiento.Nombre))
                .WithMessage("el nombre no puede estar vacía");

            RuleFor(Inquilino => Inquilino.Direccion)
                .NotEmpty().When(mantenimiento => string.IsNullOrEmpty(mantenimiento.Direccion))
                .WithMessage("la direccion no puede estar vacía");

            RuleFor(Inquilino => Inquilino.Email)
                .NotEmpty().When(mantenimiento => string.IsNullOrEmpty(mantenimiento.Email))
                .WithMessage("el email no puede estar vacía");

            RuleFor(Inquilino => Inquilino.Telefono)
                .NotEmpty().When(mantenimiento => string.IsNullOrEmpty(mantenimiento.Telefono))
                .WithMessage("el telefono no puede estar vacía");
        }
    }
}