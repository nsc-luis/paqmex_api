using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbCierre
{
    public string AnioMes { get; set; } = null!;

    public DateTime? Fecha { get; set; }
}
