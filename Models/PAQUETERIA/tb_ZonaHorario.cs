using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_ZonaHorario
{
    public int cve_ZonaHorario { get; set; }

    public string desc_ZonaHorario { get; set; } = null!;

    public byte horas { get; set; }

    public string MasMenos { get; set; } = null!;
}
