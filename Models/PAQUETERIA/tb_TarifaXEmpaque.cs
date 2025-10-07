using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_TarifaXEmpaque
{
    public byte TipoEmpaque { get; set; }

    public int cve_Origen { get; set; }

    public int cve_destino { get; set; }

    public double Desde { get; set; }

    public double Hasta { get; set; }

    public double Tarifa { get; set; }

    public int? cve_estado { get; set; }

    public byte? Tipo { get; set; }
}
