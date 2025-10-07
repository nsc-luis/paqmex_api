using PAQMEX_API.Models.JPG;

namespace PAQMEX_API.Services.JPG
{
    public class JPGService : IJPGService
    {
        private readonly JPGContext _contextJPG;
        public JPGService(JPGContext contextJPG)
        {
            _contextJPG = contextJPG;
        }
        public async Task<List<registroConsulta>> GetAllRegistros()
        {
            try
            {
                var registros = _contextJPG.registroConsultas
                    .OrderByDescending(r => r.timestamp)
                    .ToList();
                return registros;
            }
            catch
            {
                return new List<registroConsulta>();
            }
        }
        public void agregarRegistroConsulta(string consulta, string parametrosDeConsulta)
        {
            registroConsulta nuevoRegistro = new registroConsulta
            {
                consulta = consulta,
                parametrosDeConsulta = parametrosDeConsulta,
                timestamp = DateTime.Now
            };
            _contextJPG.registroConsultas.Add(nuevoRegistro);
            _contextJPG.SaveChanges();
        }
    }
}
