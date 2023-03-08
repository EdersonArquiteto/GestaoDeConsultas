using AutoMapper;
using FluentValidation;
using TheOne.Consultas.Application.DTOs;
using TheOne.Consultas.Application.Interfaces;
using TheOne.Consultas.Domain.Entities;
using TheOne.Consultas.Domain.Services;

namespace TheOne.Consultas.Application.Services
{
    public class PacienteAppService : IPacienteAppService
    {
        private readonly PacienteDomainService _pacienteDomainService;
        private readonly IMapper _mapper;

        public PacienteAppService(PacienteDomainService pacienteDomainService, IMapper mapper)
        {
            _pacienteDomainService = pacienteDomainService;
            _mapper = mapper;
        }

        public async Task CriarPaciente(PacienteDTO pacienteDTO)
        {
            #region Capturando e validando o Paciente

            var paciente = _mapper.Map<Paciente>(pacienteDTO);

            var validate = paciente.Validate;
            if (!validate.IsValid)
                throw new ValidationException(validate.Errors);

            #endregion

            #region Cadastrando o Paciente

             await  _pacienteDomainService.Create(paciente);

            #endregion
        }
    }
}
