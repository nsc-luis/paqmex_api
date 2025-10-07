using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_TempGuium
{
    public int cve_tempGuia { get; set; }

    public long? cve_guia { get; set; }

    public long? cve_guiaEstatus { get; set; }

    public string? referencia { get; set; }

    public string? num_guia { get; set; }

    public long? cve_referencia { get; set; }

    public string? observaciones { get; set; }

    public string? REFERENCIA2 { get; set; }
}
