using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbTarifaXkgOld
{
    public int CveOrigen { get; set; }

    public int CveDestino { get; set; }

    public double Desde { get; set; }

    public double Hasta { get; set; }

    public double Tarifa { get; set; }

    public int? CveEstado { get; set; }

    public byte? Tipo { get; set; }
}
