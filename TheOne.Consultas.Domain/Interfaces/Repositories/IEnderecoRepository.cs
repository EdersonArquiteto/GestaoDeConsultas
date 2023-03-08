using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheOne.Consultas.Domain.Core;
using TheOne.Consultas.Domain.Entities;

namespace TheOne.Consultas.Domain.Interfaces.Repositories
{
    public interface IEnderecoRepository : IRepository<Endereco, Guid>
    {
    }
}
