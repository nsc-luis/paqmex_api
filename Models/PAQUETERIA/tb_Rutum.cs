using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_Rutum
{
    public int Cve_ruta { get; set; }

    public string desc_ruta { get; set; } = null!;

    public int? dias { get; set; }

    public double? kms { get; set; }

    public double? SUELDO { get; set; }

    public double? MontoMaxLiq { get; set; }

    public double? MontoMaxLiqTRA { get; set; }

    public double? MontoIni1 { get; set; }

    public double? MontoIni2 { get; set; }

    public double? MontoIni3 { get; set; }

    public double? MontoFin1 { get; set; }

    public double? MontoFin2 { get; set; }

    public double? MontoFin3 { get; set; }

    public string? Califica1 { get; set; }

    public string? Califica2 { get; set; }

    public string? Califica3 { get; set; }
}
