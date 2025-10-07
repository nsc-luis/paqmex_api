using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_Tarifa
{
    public int cve_tarifa { get; set; }

    public int? cve_oficina { get; set; }

    public int PesoIni { get; set; }

    public int PesoFin { get; set; }

    public double Recoleccion { get; set; }

    public double Entrega { get; set; }
}
