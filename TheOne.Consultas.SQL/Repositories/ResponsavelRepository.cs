using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheOne.Consultas.Domain.Entities;
using TheOne.Consultas.Domain.Interfaces.Repositories;
using TheOne.Consultas.SQL.Contexts;

namespace TheOne.Consultas.SQL.Repositories
{
    public class ResponsavelRepository : Repository<Responsavel, Guid>, IResponsavelRepository
    {
        public ResponsavelRepository(SqlServerContext sqlServerContext) : base(sqlServerContext)
        {
        }
    }
}
