using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class VmCartaPorteViaje
{
    public long Id { get; set; }

    public DateTime FechaSalida { get; set; }

    public string Origen { get; set; } = null!;

    public byte CveOrigen { get; set; }

    public string? Destino { get; set; }

    public string? Chofer { get; set; }

    public string? Unidad { get; set; }

    public long? NoMercancias { get; set; }
}
