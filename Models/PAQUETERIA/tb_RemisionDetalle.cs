using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_RemisionDetalle
{
    public long Cve_RemisionDet { get; set; }

    public long Cve_Remision { get; set; }

    public byte renglon { get; set; }

    public byte? Tipo { get; set; }

    public double? kgs { get; set; }

    public int? cve_empaque { get; set; }

    public string? desc_empaque { get; set; }

    public string? contenido { get; set; }

    public int? cantidad { get; set; }
}
