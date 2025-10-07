using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_Equivalencium
{
    public int cve_oficina { get; set; }

    public int PesoIni { get; set; }

    public int PesoFin { get; set; }

    public int PesoACobrar { get; set; }
}
