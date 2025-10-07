using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_ClienteEjeCtum
{
    public long cve_cliente { get; set; }

    public int cve_EjeCta { get; set; }

    public byte TIPO { get; set; }

    public DateTime? FECHAASIG { get; set; }
}
