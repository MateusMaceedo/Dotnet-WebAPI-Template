using FluentValidation;
using Template_Modelo.Domain.Models;

namespace Template_Modelo.Domain.Validations
{
    public class ClientValidation : AbstractValidator<ClientModel>
    {
        public ClientValidation()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage("Insira o nome, para realizar o cadastro")
                .NotEmpty()
                .Length(3, 20);

            RuleFor(x => x.Email)
                .NotNull().WithMessage("Insira o email, para realizar o cadastro")
                .NotEmpty()
                .EmailAddress(FluentValidation.Validators.EmailValidationMode.AspNetCoreCompatible);

            RuleFor(x => x.PhoneNumber)
                .NotNull().WithMessage("Insira o numero de telefone, para realizar o cadastro")
                .NotEmpty();
        }
    }
}
