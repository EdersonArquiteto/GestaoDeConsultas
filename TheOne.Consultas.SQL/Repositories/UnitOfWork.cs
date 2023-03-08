using Microsoft.EntityFrameworkCore.Storage;
using TheOne.Consultas.Domain.Interfaces.Repositories;
using TheOne.Consultas.SQL.Contexts;

namespace TheOne.Consultas.SQL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SqlServerContext _sqlServerContext;
        private IDbContextTransaction _dbContextTransaction;

        public UnitOfWork(SqlServerContext sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
        }

        public IEnderecoRepository EnderecoRepository => new EnderecoRepository(_sqlServerContext);

        public IPacienteRepository PacienteRepository => new PacienteRepository(_sqlServerContext);

        public IResponsavelRepository ResponsavelRepository => new ResponsavelRepository(_sqlServerContext);



        public void BeginTransaction()
        {
            _dbContextTransaction = _sqlServerContext.Database.BeginTransaction();
        }

        public void Commit()
        {
            _dbContextTransaction.Commit();
        }

        public void Rollback()
        {
            _dbContextTransaction.Rollback();
        }

        public void Dispose()
        {
            _sqlServerContext.Dispose();
        }
    }
}
