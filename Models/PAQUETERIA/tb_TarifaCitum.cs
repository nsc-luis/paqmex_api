using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_TarifaCitum
{
    public int cve_tarifa { get; set; }

    public byte cve_oficina { get; set; }

    public int PesoIni { get; set; }

    public int PesoFin { get; set; }

    public double Tarifa { get; set; }
}
