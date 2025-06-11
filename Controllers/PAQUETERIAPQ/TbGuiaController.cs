using Microsoft.AspNetCore.Mvc;
using PAQMEX_API.Data.PAQUETERIAPQ;
using PAQMEX_API.Models.PAQUETERIAPQ;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PAQMEX_API.Controllers.PAQUETERIAPQ
{
    [Route("api/[controller]")]
    [ApiController]
    public class TbGuiaController : ControllerBase
    {
        private readonly PaqueteriapqContext _context;
        public TbGuiaController(PaqueteriapqContext context)
        {
            _context = context;
        }

        // GET: api/<TbGuiaController>
        [HttpGet]
        public ActionResult Get()
        {
            TbGuiaData guiaData = new TbGuiaData(_context);
            List<TbGuia> guias = guiaData.getGuias();
            return Ok(guias);
        }

        //// GET api/<TbGuiaController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<TbGuiaController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<TbGuiaController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<TbGuiaController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
