using TheOne.Consultas.Domain.Entities;
using TheOne.Consultas.Domain.Interfaces.Repositories;
using TheOne.Consultas.SQL.Contexts;

namespace TheOne.Consultas.SQL.Repositories
{
    public class EnderecoRepository : Repository<Endereco, Guid>, IEnderecoRepository
    {
        public EnderecoRepository(SqlServerContext sqlServerContext) : base(sqlServerContext)
        {
        }
    }
}
