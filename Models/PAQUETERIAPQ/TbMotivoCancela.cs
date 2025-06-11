using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbMotivoCancela
{
    public int CveMotivo { get; set; }

    public string? DescMotivo { get; set; }

    public bool? Activo { get; set; }

    public bool? CancelaDirecto { get; set; }
}
