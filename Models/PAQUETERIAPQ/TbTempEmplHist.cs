using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbTempEmplHist
{
    public long CveTempEmplHist { get; set; }

    public int CveEmpleado { get; set; }

    public DateTime Fecha { get; set; }

    public string Descripcion { get; set; } = null!;
}
