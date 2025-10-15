using Newtonsoft.Json;
using PAQMEX_API.Models.PAQUETERIAPQ;
using PAQMEX_API.Services.JPG;
using static PAQMEX_API.Services.PAQUETERIAPQ.IPAQUETERIAPQService;

namespace PAQMEX_API.Services.PAQUETERIAPQ
{
    public class PAQUETERIAPQService : IPAQUETERIAPQService
    {
        private readonly PaqueteriapqContext _context;
        private readonly IJPGService _jpgService;

        public PAQUETERIAPQService(PaqueteriapqContext context, IJPGService jpgService)
        {
            _context = context;
            _jpgService = jpgService;
        }        
        public async Task<List<GuiasUrrea>> getGuias(RangoDeFechas rangoDeFechas)
        {
            List<GuiasUrrea> guias = new List<GuiasUrrea>();
            if (rangoDeFechas.start_date == null || rangoDeFechas.end_date == null)
            {
                return guias = null;
            }
            string start_date1 = rangoDeFechas.start_date.Value.ToString("yyyy-MM-dd") + "T00:00:00.000";
            string end_date1 = rangoDeFechas.end_date.Value.ToString("yyyy-MM-dd") + "T23:59:59.000";
            DateTime start_date = DateTime.Parse(start_date1);
            DateTime end_date = DateTime.Parse(end_date1);

            var query = (from g in _context.TbGuias
                         //join gt in _context.TbGuiaTimbres on g.NumGuia equals gt.NumGuia
                         where (g.Fechaentrega >= start_date && g.Fechaentrega <= end_date)
                         && g.CveClienteRem == 105803 //URREA
                         orderby g.Fechaentrega descending
                         select new
                         {
                             g.NumGuia,
                             g.NumFacCte,
                             g.CodigoRastreo,
                             //gt.Uuid,
                             g.Fechaentrega,
                             g.RecibeEnt
                         });
            guias = query.Select(g => new GuiasUrrea
            {
                //guia = g.NumGuia,
                guia = g.CodigoRastreo,
                pedido = g.NumFacCte,
                //factura = g.Uuid,
                factura = g.NumGuia,
                fecha_entrega = g.Fechaentrega,
                recibido_por = g.RecibeEnt
            }).ToList();

            _jpgService.agregarRegistroConsulta("urrea/api/v1/guias/entregas/consulta", JsonConvert.SerializeObject(rangoDeFechas));
            return guias;
        }
    }
}
