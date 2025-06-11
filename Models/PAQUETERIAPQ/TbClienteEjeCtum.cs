using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbClienteEjeCtum
{
    public long CveCliente { get; set; }

    public int CveEjeCta { get; set; }

    public byte Tipo { get; set; }

    public DateTime? Fechaasig { get; set; }
}
