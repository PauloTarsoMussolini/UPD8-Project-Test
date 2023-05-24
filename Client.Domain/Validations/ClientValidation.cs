using Client.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Domain.Validations
{
    public class ClientValidation : AbstractValidator<ClientModel>
    {
        public ClientValidation()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .NotNull()
                .Length(3,75);
            RuleFor(c => c.Address)
                .NotEmpty()
                .NotNull()
                .Length(10, 75);
            RuleFor(c => c.Cpf)
                .NotEmpty()
                .NotNull()
                .Length(11, 11);
        }
    }
}
