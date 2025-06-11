using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbClienteTransfer
{
    public long CveCliente { get; set; }

    public string Cuenta { get; set; } = null!;

    public int? CveBanco { get; set; }

    public string? NomBanco { get; set; }

    public string? Tipo { get; set; }
}
