using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_TempProg
{
    public int cve_TempProg { get; set; }

    public int? cve_programa { get; set; }

    public string? referencia { get; set; }

    public string? refe { get; set; }
}
