using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheOne.Consultas.Application.DTOs;

namespace TheOne.Consultas.Application.Interfaces
{
    public interface IPacienteAppService
    {
        Task CriarPaciente(PacienteDTO pacienteDTO);
    }
}
