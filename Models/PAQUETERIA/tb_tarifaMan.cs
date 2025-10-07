using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_tarifaMan
{
    public int cve_tarifa { get; set; }

    public long cve_cliente { get; set; }

    public int cve_empaque { get; set; }

    public double? tarifaDes { get; set; }

    public double? tarifaEst { get; set; }
}
