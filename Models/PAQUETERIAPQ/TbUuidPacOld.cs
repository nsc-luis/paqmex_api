using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbUuidPacOld
{
    public string Uuid { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public bool Cancelar { get; set; }

    public DateTime? FechaTimbre { get; set; }

    public string? Datos { get; set; }
}
