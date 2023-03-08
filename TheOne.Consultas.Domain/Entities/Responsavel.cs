using FluentValidation.Results;
using TheOne.Consultas.Domain.Core;
using TheOne.Consultas.Domain.VO;
using TheOne.Consultas.Validations;

namespace TheOne.Consultas.Domain.Entities
{
    public class Responsavel : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string? Profissao { get; set; }
        public bool ResponsavelNF { get; set; }
        public bool ResponsavelPrincipal { get; set; }
        public Email Email { get; set; }
        public Telefone Telefone { get; set; }
        public Telefone Celular { get; set; }
        public string? RG { get; set; }
        public CPF CPF { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        public virtual List<Paciente>? Pacientes { get; set; }

        public ValidationResult Validate => new ResponsavelValidation().Validate(this);

    }
}
