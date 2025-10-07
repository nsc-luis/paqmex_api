using Microsoft.AspNetCore.Mvc;
using PAQMEX_API.Services.JPG;

namespace PAQMEX_API.Controllers.JPG
{
    public class RegistroConsultaController : Controller
    {
        private readonly IJPGService _jpgService;
        public RegistroConsultaController(IJPGService jpgService)
        {
            _jpgService = jpgService;
        }
        [HttpGet]
        [Route("api/jpg/registroConsultas")]
        public async Task<IActionResult> GetAllRegistros()
        {
            var registros = await _jpgService.GetAllRegistros();
            if (registros == null || registros.Count == 0)
            {
                return NotFound("No se encontraron registros de consultas.");
            }
            return Ok(registros);
        }
    }
}
