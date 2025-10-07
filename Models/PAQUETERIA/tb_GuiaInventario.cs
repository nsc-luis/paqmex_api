using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_GuiaInventario
{
    public long cve_guia { get; set; }

    public DateTime fechaInv { get; set; }

    public string? num_guia { get; set; }

    public int? CVE_USUARIO { get; set; }

    public string? NOM_USUARIO { get; set; }

    public int? cve_oficina { get; set; }

    public string? observaciones { get; set; }
}
