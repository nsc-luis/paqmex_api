using PAQMEX_API.Models.PAQUETERIAPQ;

namespace PAQMEX_API.Data.PAQUETERIAPQ
{
    public class TbGuiaData
    {
        private readonly PaqueteriapqContext _context;
        public TbGuiaData(PaqueteriapqContext context)
        {
            _context = context;
        }
        public List<TbGuia> getGuias()
        {
            var guias = (from g in _context.TbGuias
                         orderby g.FechaAlta descending
                         select g).Take(5);
            return guias.ToList();
        }
    }
}
