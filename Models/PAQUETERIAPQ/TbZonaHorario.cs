using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbZonaHorario
{
    public int CveZonaHorario { get; set; }

    public string DescZonaHorario { get; set; } = null!;

    public byte Horas { get; set; }

    public string MasMenos { get; set; } = null!;
}
