using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_ClienteEmbarque
{
    public long Cve_Embarque { get; set; }

    public long Cve_Cliente { get; set; }

    public string direccion { get; set; } = null!;

    public string? colonia { get; set; }

    public string? cp { get; set; }

    public int cve_ciudad { get; set; }

    public int cve_estado { get; set; }

    public string? tel1 { get; set; }

    public string? tel2 { get; set; }

    public bool foranea { get; set; }

    public int? cve_colonia { get; set; }

    public int? cve_direccion { get; set; }

    public string? NumExt { get; set; }

    public string? NumInt { get; set; }

    public string? CveSAT_Colonia { get; set; }

    public string? CveSAT_Localidad { get; set; }

    public string? CveSAT_Municipio { get; set; }

    public string? CveSAT_Estado { get; set; }
}
