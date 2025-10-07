using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_Regiman
{
    public DateOnly FechaIni { get; set; }

    public DateOnly FechaFin { get; set; }

    public string regimen { get; set; } = null!;
}
