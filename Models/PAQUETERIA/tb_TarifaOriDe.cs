using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_TarifaOriDe
{
    public int cve_ofiOri { get; set; }

    public int cve_destino { get; set; }

    public double PesoMin { get; set; }

    public double Tarifa { get; set; }

    public double? CuotaTon { get; set; }
}
