using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbTarifaPromo
{
    public int CveOfiOri { get; set; }

    public int CveDestino { get; set; }

    public double Tarifa { get; set; }
}
