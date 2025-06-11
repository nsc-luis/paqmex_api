using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbComandadetBorrar
{
    public long CveComandaDet { get; set; }

    public long? CveComanda { get; set; }

    public int? Cantidad { get; set; }

    public int? CveEmpaque { get; set; }

    public string? DescEmpaque { get; set; }

    public string? Contenido { get; set; }

    public double? Largo { get; set; }

    public double? Alto { get; set; }

    public double? Ancho { get; set; }

    public double? KgsReal { get; set; }

    public double? KgsVolTot { get; set; }
}
