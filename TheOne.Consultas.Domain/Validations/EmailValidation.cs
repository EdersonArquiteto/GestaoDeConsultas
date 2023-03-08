using FluentValidation;
using System.Text.RegularExpressions;
using TheOne.Consultas.Domain.VO;

namespace TheOne.Consultas.Validations
{
    public class EmailValidation : AbstractValidator<Email>
    {
        private const string Pattern = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";

        private bool BeAEmailValid(string valor) => Regex.IsMatch(valor, Pattern);
        public EmailValidation()
        {
            RuleFor(x => x.Value).NotEmpty().Must(BeAEmailValid).WithMessage("Email invalido");
        }
    }
}
