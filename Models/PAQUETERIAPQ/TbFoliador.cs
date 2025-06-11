using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbFoliador
{
    public int? TcveGuia { get; set; }

    public int? TcveDetGuia { get; set; }

    public int? TcveProg { get; set; }

    public int? TcveOficina { get; set; }

    public long? TcveManiobra { get; set; }

    public long? TcveEmplHist { get; set; }

    public long? TcveGuiaExp { get; set; }

    public long? TCveContraRecibo { get; set; }
}
