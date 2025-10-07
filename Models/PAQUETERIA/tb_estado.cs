using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_estado
{
    public int Cve_estado { get; set; }

    public string nom_estado { get; set; } = null!;

    public bool? ACTIVO { get; set; }
}
