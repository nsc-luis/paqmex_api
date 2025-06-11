using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbEstado
{
    public int CveEstado { get; set; }

    public string NomEstado { get; set; } = null!;

    public bool? Activo { get; set; }
}
