using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_TarifaPromo
{
    public int cve_ofiOri { get; set; }

    public int cve_Destino { get; set; }

    public double Tarifa { get; set; }
}
