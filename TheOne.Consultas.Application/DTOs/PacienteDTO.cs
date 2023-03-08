using TheOne.Consultas.Domain.Entities;
using TheOne.Consultas.Domain.VO;

namespace TheOne.Consultas.Application.DTOs
{
    public class PacienteDTO
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataPrimeiraAvaliacao { get; set; }
        public bool ResponsavelNF { get; set; }
        public string? RG { get; set; }
        public CPF CPF { get; set; }

        public virtual ICollection<Responsavel>? Responsaveis { get; set; }
        public Endereco? Endereco { get; set; }

    }
}
