using PAQMEX_API.Models.PAQUETERIAPQ;
using PAQMEX_API.Services.JPG;

namespace PAQMEX_API.Security
{
    public class AuthUrreaService : IAuthUrreaService
    {
        private readonly PaqueteriapqContext _context;
        public AuthUrreaService(PaqueteriapqContext context)
        {
            _context = context;
        }
        public bool IsUserValid(int cveCliente, string pwdInternet)
        {
            string pwdEnBD = _context.TbClientes.Where(c => c.CveCliente == cveCliente)
                .Select(c => c.PwdInternet)
                .FirstOrDefault();
            if (cveCliente == 105803 && pwdInternet == pwdEnBD)
            {
                return true; // Usuario válido
            }
            return false; // Usuario inválido
        }
    }
}
