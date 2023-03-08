using TheOne.Consultas.Domain.Entities;
using TheOne.Consultas.Domain.Interfaces.Repositories;
using TheOne.Consultas.SQL.Contexts;

namespace TheOne.Consultas.SQL.Repositories
{
    public class PacienteRepository : Repository<Paciente, Guid>, IPacienteRepository
    {
        public PacienteRepository(SqlServerContext sqlServerContext) : base(sqlServerContext)
        {
        }
    }
}
