using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheOne.Consultas.Domain.Entities;
using TheOne.Consultas.Domain.Interfaces.Repositories;
using TheOne.Consultas.Domain.Interfaces.Services;

namespace TheOne.Consultas.Domain.Services
{
    public class PacienteDomainService : IBaseDomainService<Paciente, Guid>
    {
        private readonly IUnitOfWork _unitOfWork;

        public PacienteDomainService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Create(Paciente entity)
        {
            await _unitOfWork.PacienteRepository.Create(entity);
        }

        public async Task Update(Paciente entity)
        {
            await _unitOfWork.PacienteRepository.Update(entity);
        }

        public async Task Delete(Paciente entity)
        {
            await _unitOfWork.PacienteRepository.Delete(entity);
        }

        public async Task<Paciente> Get(Guid id)
        {
            var paciente = await _unitOfWork.PacienteRepository.Get(id);
            return paciente;
        }

        public async Task<IList<Paciente>> GetAll()
        {
            var pacientes = await _unitOfWork.PacienteRepository.GetAll();
            return pacientes.ToList();
        }


    }
}
