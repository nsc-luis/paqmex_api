using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbPropietario
{
    public byte CvePropietario { get; set; }

    public string NomPropietario { get; set; } = null!;

    public bool? Permisionario { get; set; }

    public string? Contacto { get; set; }

    public string? Tels { get; set; }

    public string? Email { get; set; }

    public string? CveSatTipoPerm { get; set; }

    public string? PermisoSct { get; set; }
}
