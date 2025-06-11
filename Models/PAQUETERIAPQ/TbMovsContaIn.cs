using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbMovsContaIn
{
    public byte Tipo { get; set; }

    public double Importe { get; set; }

    public double Descuento { get; set; }

    public double RetIvag { get; set; }

    public double TotalG { get; set; }

    public double Ivag { get; set; }

    public int CveOficina { get; set; }

    public DateTime Fecha { get; set; }

    public string Ficha { get; set; } = null!;

    public int CveBanco { get; set; }

    public string NomBanco { get; set; } = null!;

    public string CuentaContDep { get; set; } = null!;

    public long CveGuiaestatusPa { get; set; }

    public long CveGuiaestatusCo { get; set; }

    public long CveGuiaestatusCa { get; set; }

    public string Poliza { get; set; } = null!;

    public int CveCuentaBco { get; set; }

    public string? NumCuentaBco { get; set; }

    public DateTime? FechaComp { get; set; }

    public decimal? PorcIva { get; set; }
}
