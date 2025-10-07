using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_EstatusTR
{
    public int Cve_estatus { get; set; }

    public string desc_estatus { get; set; } = null!;

    public byte tipo { get; set; }

    public byte? aCTIVO { get; set; }
}
