using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbTarifaPesoMin
{
    public int CveOfiOri { get; set; }

    public int CveOfiDes { get; set; }

    public double PesoMin { get; set; }

    public double Tarifa { get; set; }

    public double? CuotaTon { get; set; }
}
