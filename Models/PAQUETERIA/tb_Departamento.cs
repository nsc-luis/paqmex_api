using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_Departamento
{
    public int Cve_depto { get; set; }

    public string desc_depto { get; set; } = null!;

    public bool? RecibePago { get; set; }

    public string? PREFIJO { get; set; }
}
