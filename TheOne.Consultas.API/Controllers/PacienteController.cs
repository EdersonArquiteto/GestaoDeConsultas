using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheOne.Consultas.Application.DTOs;
using TheOne.Consultas.Application.Interfaces;

namespace TheOne.Consultas.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private readonly IPacienteAppService _pacienteAppService;

        public PacienteController(IPacienteAppService pacienteAppService)
        {
            _pacienteAppService = pacienteAppService;
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarPaciente(PacienteDTO pacienteDTO)
        {
            await _pacienteAppService.CriarPaciente(pacienteDTO);
            return StatusCode(200, new
            {
                message = "Paciente cadastrado com sucesso"
            });
        }
    }
}
