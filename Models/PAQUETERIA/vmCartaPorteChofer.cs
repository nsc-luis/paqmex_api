using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class vmCartaPorteChofer
{
    public int IdChofer { get; set; }

    public string NombreChofer { get; set; } = null!;

    public string ApellidoChofer { get; set; } = null!;

    public string? RFC { get; set; }

    public string? Licencia { get; set; }
}
