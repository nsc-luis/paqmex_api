using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_Propietario
{
    public byte Cve_propietario { get; set; }

    public string nom_propietario { get; set; } = null!;

    public bool? PERMISIONARIO { get; set; }

    public string? CONTACTO { get; set; }

    public string? TELS { get; set; }

    public string? EMAIL { get; set; }

    public string? CveSAT_TipoPerm { get; set; }

    public string? PermisoSCT { get; set; }
}
