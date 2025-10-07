using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PAQMEX_API.Services.JPG;
using PAQMEX_API.Services.PAQUETERIAPQ;
using static PAQMEX_API.Services.PAQUETERIAPQ.IPAQUETERIAPQService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PAQMEX_API.Controllers.PAQUETERIAPQ
{
    [Route("api/[controller]")]
    //[Route("api/v1/guias/entregas/consulta")]
    [ApiController]
    public class TbGuiaController : ControllerBase
    {
        private readonly IPAQUETERIAPQService _paqueteriapqService;
        private readonly IJPGService _jpgService;
        public TbGuiaController(IPAQUETERIAPQService paqueteriapqService, IJPGService jpgService)
        {
            _paqueteriapqService = paqueteriapqService;
            _jpgService = jpgService;
        }
        [HttpPost]
        [Authorize]
        public ActionResult Post([FromBody] RangoDeFechas rangoDeFechas)
        {
            try
            {
                if (rangoDeFechas.start_date == null || rangoDeFechas.end_date == null)
                {
                    return BadRequest(new
                    {
                        error = "Debe proporcionar ambas fechas: start_date y end_date."
                    });
                }
                
                var guias = _paqueteriapqService.getGuias(rangoDeFechas);
                return Ok(guias.Result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
