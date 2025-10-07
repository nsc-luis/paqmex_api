using PAQMEX_API.Models.JPG;

namespace PAQMEX_API.Services.JPG
{
    public interface IJPGService
    {
        public Task<List<registroConsulta>> GetAllRegistros();
        public void agregarRegistroConsulta(string consulta, string parametrosDeConsulta);
    }
}
