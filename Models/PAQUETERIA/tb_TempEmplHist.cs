using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_TempEmplHist
{
    public long Cve_TempEmplHist { get; set; }

    public int Cve_empleado { get; set; }

    public DateTime fecha { get; set; }

    public string descripcion { get; set; } = null!;
}
