using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_direccion
{
    public int Cve_direccion { get; set; }

    public string calle { get; set; } = null!;

    public string cp { get; set; } = null!;

    public bool CargaAut { get; set; }

    public int cve_ciudad { get; set; }

    public int cve_estado { get; set; }

    public int cve_colonia { get; set; }

    public string? CUADRANTE { get; set; }

    public string? CODZONA { get; set; }

    public string? CODPOSTAL { get; set; }

    public int? CVE_OPERADOR { get; set; }

    public int? CVE_SUPERVISOR { get; set; }

    public string? nom_colonia { get; set; }
}
