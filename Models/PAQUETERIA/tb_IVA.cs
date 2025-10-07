using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_IVA
{
    public DateTime fechaIni { get; set; }

    public DateTime fechaFin { get; set; }

    public int? PorcIVA { get; set; }
}
