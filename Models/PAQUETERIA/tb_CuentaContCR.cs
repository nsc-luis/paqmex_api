using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_CuentaContCR
{
    public int cve_cuentaContCR { get; set; }

    public int cve_cuentaCont { get; set; }

    public string desc_cuentaCont { get; set; } = null!;

    public string? nom_cuentaCont { get; set; }

    public string cuentaCont { get; set; } = null!;

    public int? cve_oficina { get; set; }

    public byte TipoCta { get; set; }

    public double? Porcentaje { get; set; }
}
