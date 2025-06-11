using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class VmCartaPorteChofer
{
    public int IdChofer { get; set; }

    public string NombreChofer { get; set; } = null!;

    public string ApellidoChofer { get; set; } = null!;

    public string? Rfc { get; set; }

    public string? Licencia { get; set; }
}
