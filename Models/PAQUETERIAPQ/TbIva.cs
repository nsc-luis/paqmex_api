using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbIva
{
    public DateTime FechaIni { get; set; }

    public DateTime FechaFin { get; set; }

    public int? PorcIva { get; set; }
}
