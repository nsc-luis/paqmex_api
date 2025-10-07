using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_TarifaCC
{
    public int cve_ofiOri { get; set; }

    public int cve_OfiDes { get; set; }

    public double Tarifa { get; set; }

    public double TarifaMin { get; set; }

    public double? kms { get; set; }
}
