using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.ENTREGAS;

public partial class TB_COMANDADET
{
    public long cve_comandaDet { get; set; }

    public long? cve_comanda { get; set; }

    public int? cantidad { get; set; }

    public int? cve_empaque { get; set; }

    public string? desc_empaque { get; set; }

    public string? contenido { get; set; }

    public double? largo { get; set; }

    public double? alto { get; set; }

    public double? ancho { get; set; }

    public double? KgsReal { get; set; }

    public double? KgsVolTot { get; set; }
}
