using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbZona
{
    public int CveZona { get; set; }

    public string? DescZona { get; set; }

    public int? CveOficina { get; set; }

    public int? Bloque { get; set; }

    public byte? Orden { get; set; }

    public string? Abreviatura { get; set; }
}
