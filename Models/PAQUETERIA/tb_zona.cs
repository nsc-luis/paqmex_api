using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_zona
{
    public int cve_zona { get; set; }

    public string? desc_zona { get; set; }

    public int? cve_oficina { get; set; }

    public int? bloque { get; set; }

    public byte? orden { get; set; }

    public string? abreviatura { get; set; }
}
