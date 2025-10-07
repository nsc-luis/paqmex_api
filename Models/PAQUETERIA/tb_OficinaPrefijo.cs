using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_OficinaPrefijo
{
    public byte Cve_Oficina { get; set; }

    public byte Cve_OficinaDest { get; set; }

    public int cve_serie { get; set; }
}
