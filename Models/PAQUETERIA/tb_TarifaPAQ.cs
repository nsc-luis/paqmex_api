using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_TarifaPAQ
{
    public int cve_tarifa { get; set; }

    public int cve_ofiOri { get; set; }

    public int cve_OfiDes { get; set; }

    public int PesoIni { get; set; }

    public int PesoFin { get; set; }

    public byte Tipo { get; set; }

    public double Tarifa { get; set; }
}
