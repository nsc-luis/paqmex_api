using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class vmCartaPorteRemolque
{
    public string IdRemolque { get; set; } = null!;

    public string? Marca { get; set; }

    public double? Capacidad { get; set; }

    public string? Modelo { get; set; }

    public string? Serie { get; set; }

    public string? Placa { get; set; }
}
