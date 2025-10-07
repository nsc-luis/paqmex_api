using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_ConceptoVtaAct
{
    public int cve_concepto { get; set; }

    public string? desc_concepto { get; set; }

    public bool? gravable { get; set; }

    public string? cve_prodServSAT { get; set; }

    public string? desc_prodServSAT { get; set; }

    public string? UniMed { get; set; }
}
