using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_ClienteCred
{
    public long? cve_cliente { get; set; }

    public DateTime? fechaCred { get; set; }

    public byte? CondPago { get; set; }

    public int? cve_usuario { get; set; }

    public string? nom_usuario { get; set; }
}
