using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbGuiaPago
{
    public long CveGuia { get; set; }

    public string? Referencia { get; set; }

    public int? CveBanco { get; set; }

    public string? NomBanco { get; set; }

    public byte? FormaPago { get; set; }

    public string? CuentaChq { get; set; }
}
