using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbTarifaMan
{
    public int CveTarifa { get; set; }

    public long CveCliente { get; set; }

    public int CveEmpaque { get; set; }

    public double? TarifaDes { get; set; }

    public double? TarifaEst { get; set; }
}
