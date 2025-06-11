using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbTempGuium
{
    public int CveTempGuia { get; set; }

    public long? CveGuia { get; set; }

    public long? CveGuiaEstatus { get; set; }

    public string? Referencia { get; set; }

    public string? NumGuia { get; set; }

    public long? CveReferencia { get; set; }

    public string? Observaciones { get; set; }

    public string? Referencia2 { get; set; }
}
