namespace PAQMEX_API.Services.PAQUETERIAPQ
{
    public interface IPAQUETERIAPQService
    {
        public class GuiasUrrea
        {
            public string guia { get; set; }
            public string pedido { get; set; }
            public string factura { get; set; }
            public DateTime? fecha_entrega { get; set; }
            public string recibido_por { get; set; }
        }
        public class RangoDeFechas
        {
            public DateOnly? start_date { get; set; }
            public DateOnly? end_date { get; set; }
        }
        public Task<List<GuiasUrrea>> getGuias(RangoDeFechas rangoDeFechas);
    }
}
