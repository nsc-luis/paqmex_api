using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbRemisionDetalle
{
    public long CveRemisionDet { get; set; }

    public long CveRemision { get; set; }

    public byte Renglon { get; set; }

    public byte? Tipo { get; set; }

    public double? Kgs { get; set; }

    public int? CveEmpaque { get; set; }

    public string? DescEmpaque { get; set; }

    public string? Contenido { get; set; }

    public int? Cantidad { get; set; }
}
