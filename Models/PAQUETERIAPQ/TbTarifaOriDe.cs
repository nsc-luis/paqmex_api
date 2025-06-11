using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbTarifaOriDe
{
    public int CveOfiOri { get; set; }

    public int CveDestino { get; set; }

    public double PesoMin { get; set; }

    public double Tarifa { get; set; }

    public double? CuotaTon { get; set; }
}
