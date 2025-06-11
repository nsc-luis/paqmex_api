using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbTarifaCc
{
    public int CveOfiOri { get; set; }

    public int CveOfiDes { get; set; }

    public double Tarifa { get; set; }

    public double TarifaMin { get; set; }

    public double? Kms { get; set; }
}
