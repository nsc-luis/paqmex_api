using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbDepartamento
{
    public int CveDepto { get; set; }

    public string DescDepto { get; set; } = null!;

    public bool? RecibePago { get; set; }

    public string? Prefijo { get; set; }
}
