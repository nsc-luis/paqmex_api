using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_DiasEntrega
{
    public int cve_oficinaOri { get; set; }

    public int cve_OficinaDes { get; set; }

    public int? dias { get; set; }
}
