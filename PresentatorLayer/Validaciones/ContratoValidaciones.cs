using CommonLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PresentatorLayer.Validaciones
{
    public class contratosValidator : AbstractValidator<Contratos>
    {
        public contratosValidator()
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(contrato => contrato.FechaInicio)
                .NotEmpty().WithMessage("La fecha de inicio no puede estar vacía")
                .GreaterThanOrEqualTo(DateTime.Now.Date)
                .WithMessage("La fecha de inicio no puede ser anterior a la fecha actual");

            RuleFor(contrato => contrato.FechaFin)
                .NotEmpty().WithMessage("La fecha de fin no puede estar vacía")
                .GreaterThanOrEqualTo(contrato => contrato.FechaInicio)
                .WithMessage("La fecha de fin debe ser mayor o igual a la fecha de inicio");


            RuleFor(Contratos => Contratos.MontoMensual)
                .NotEmpty().When(Contratos => string.IsNullOrEmpty(Contratos.MontoMensual))
                .WithMessage("El monto no puede estar vacio")
                .Matches(@"^\d+(\.\d+)?$").WithMessage("El monto debe tener solo números, con un punto opcional para decimales");

            RuleFor(contrato => contrato.PropiedadId)
                .NotEmpty().WithMessage("Por favor, seleccione una propiedad")
                .When(contrato => contrato.PropiedadId != null);
        }
    }
}