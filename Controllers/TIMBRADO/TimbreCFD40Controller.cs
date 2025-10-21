using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PAQMEX_API.Services.CFDv40;
using PAQMEX_API.Services.JPG;
using PAQMEX_API.Services.PAQUETERIAPQ;

namespace PAQMEX_API.Controllers.TIMBRADO
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimbreCFD40Controller : ControllerBase
    {
        private readonly ICFDv40Service _cfd40Service;
        public TimbreCFD40Controller(ICFDv40Service cfd40Service)
        {
            _cfd40Service = cfd40Service;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Comprobante comprobante)
        {
            //try
            //{
                _cfd40Service.GeneraCFDv40(comprobante);
                return Ok(new
                {
                    message = "CFD v4.0 generado correctamente."
                });
            //}
            //catch (Exception ex)
            //{
            //    return BadRequest(ex.Message);
            //}
        }
    }
}
