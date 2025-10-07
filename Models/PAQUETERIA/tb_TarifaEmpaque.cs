using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_TarifaEmpaque
{
    public long cve_tarifa { get; set; }

    public int cve_oficinaOri { get; set; }

    public int cve_OficinaDes { get; set; }

    public int? cve_empaque { get; set; }

    public double tarifa { get; set; }

    public byte? TipoCarga { get; set; }

    public double? Minimo { get; set; }

    public DateTime? FechaAlta { get; set; }
}
