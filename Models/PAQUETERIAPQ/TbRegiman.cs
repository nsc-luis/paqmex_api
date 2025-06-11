using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbRegiman
{
    public DateOnly FechaIni { get; set; }

    public DateOnly FechaFin { get; set; }

    public string Regimen { get; set; } = null!;
}
