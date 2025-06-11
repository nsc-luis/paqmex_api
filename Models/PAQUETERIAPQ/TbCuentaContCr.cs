using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbCuentaContCr
{
    public int CveCuentaContCr { get; set; }

    public int CveCuentaCont { get; set; }

    public string DescCuentaCont { get; set; } = null!;

    public string? NomCuentaCont { get; set; }

    public string CuentaCont { get; set; } = null!;

    public int? CveOficina { get; set; }

    public byte TipoCta { get; set; }

    public double? Porcentaje { get; set; }
}
