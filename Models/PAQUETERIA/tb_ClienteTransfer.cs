using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_ClienteTransfer
{
    public long cve_cliente { get; set; }

    public string cuenta { get; set; } = null!;

    public int? cve_banco { get; set; }

    public string? nom_banco { get; set; }

    public string? Tipo { get; set; }
}
