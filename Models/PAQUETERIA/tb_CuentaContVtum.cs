using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_CuentaContVtum
{
    public int cve_oficina { get; set; }

    public string cuenta_contV { get; set; } = null!;

    public string descripcionV { get; set; } = null!;

    public string nombreV { get; set; } = null!;

    public string cuenta_contF { get; set; } = null!;

    public string descripcionF { get; set; } = null!;

    public string nombreF { get; set; } = null!;

    public string cuenta_contRE { get; set; } = null!;

    public string descripcionRE { get; set; } = null!;

    public string nombreRE { get; set; } = null!;

    public string cuenta_contO { get; set; } = null!;

    public string descripcionO { get; set; } = null!;

    public string nombreO { get; set; } = null!;

    public string cuenta_contS { get; set; } = null!;

    public string descripcionS { get; set; } = null!;

    public string nombreS { get; set; } = null!;

    public string cuenta_contIVA { get; set; } = null!;

    public string descripcionIVA { get; set; } = null!;

    public string nombreIVA { get; set; } = null!;

    public string cuenta_contRIVA { get; set; } = null!;

    public string descripcionRIVA { get; set; } = null!;

    public string nombreRIVA { get; set; } = null!;

    public string? desc_CuentaContNCR { get; set; }

    public string? nom_CuentaContNCR { get; set; }

    public string? cuentaContNCR { get; set; }
}
