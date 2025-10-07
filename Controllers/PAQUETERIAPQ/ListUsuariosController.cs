using Microsoft.AspNetCore.Mvc;
using PAQMEX_API.Data.PAQUETERIAPQ;
using PAQMEX_API.Models.PAQUETERIAPQ;
using static PAQMEX_API.Data.PAQUETERIAPQ.ListUsuarios;
using static System.Runtime.InteropServices.JavaScript.JSType;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PAQMEX_API.Controllers.PAQUETERIAPQ
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListUsuariosController : ControllerBase
    {
        private readonly PaqueteriapqContext _context;
        public ListUsuariosController(PaqueteriapqContext context)
        {
            _context = context;
        }

        // GET: api/<UsuarioController>
        //[HttpPost]
        //[Route("[action]")]
        //public ActionResult ListUsuarios([FromBody] objListaUsuarios obj)
        //{
        //    try
        //    {
        //        ListUsuarios tbUsuarioData = new ListUsuarios(_context);
        //        var usuarios = tbUsuarioData.ListUsuariosData(obj);
        //        if (usuarios.Count == 0)
        //        {
        //            return Ok(new
        //            {
        //                estatus = "error",
        //                mensaje = "No existe el usuario o los datos están incorrectos."
        //            });
        //        }
        //        else
        //        {
        //            return Ok(new
        //            {
        //                estatus = "success",
        //                usuarios
        //            });
        //        }
                    
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(new
        //        {
        //            estatus = "error",
        //            mensaje = ex.Message,
        //        });
        //    }
        //}

        //// GET api/<UsuarioController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<UsuarioController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<UsuarioController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<UsuarioController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
