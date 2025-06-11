using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbRutum
{
    public int CveRuta { get; set; }

    public string DescRuta { get; set; } = null!;

    public int? Dias { get; set; }

    public double? Kms { get; set; }

    public double? Sueldo { get; set; }

    public double? MontoMaxLiq { get; set; }

    public double? MontoMaxLiqTra { get; set; }

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
