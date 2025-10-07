using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_cierre
{
    public string AnioMes { get; set; } = null!;

    public DateTime? Fecha { get; set; }
}
