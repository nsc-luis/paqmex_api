using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_GrupoConv
{
    public int cve_grupo { get; set; }

    public string? desc_grupo { get; set; }

    public int? CVE_OFICINA { get; set; }
}
