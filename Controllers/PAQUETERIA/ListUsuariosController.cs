using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PAQMEX_API.Data.PAQUETERIA;
using PAQMEX_API.Models.PAQUETERIA;
using PAQMEX_API.Models.PAQUETERIAPQ;
using static PAQMEX_API.Data.PAQUETERIA.ListUsuarios1;

namespace PAQMEX_API.Controllers.PAQUETERIA
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListUsuarios1Controller : ControllerBase
    {
        private readonly PAQUETERIAContext _context;
        public ListUsuarios1Controller(PAQUETERIAContext context)
        {
            _context = context;
        }

        // GET: api/<UsuarioController>
        //[HttpPost]
        //[Route("[action]")]
        //public ActionResult ListUsuarios1([FromBody] objListaUsuarios1 obj)
        //{
        //    try
        //    {
        //        ListUsuarios1 tbUsuarioData = new ListUsuarios1(_context);
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
    }
}
