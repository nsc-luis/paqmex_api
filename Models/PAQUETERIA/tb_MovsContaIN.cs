using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_MovsContaIN
{
    public byte Tipo { get; set; }

    public double Importe { get; set; }

    public double Descuento { get; set; }

    public double RetIVAG { get; set; }

    public double TotalG { get; set; }

    public double IVAG { get; set; }

    public int cve_oficina { get; set; }

    public DateTime fecha { get; set; }

    public string Ficha { get; set; } = null!;

    public int cve_banco { get; set; }

    public string nom_banco { get; set; } = null!;

    public string cuenta_contDEP { get; set; } = null!;

    public long cve_guiaestatusPA { get; set; }

    public long cve_guiaestatusCO { get; set; }

    public long cve_guiaestatusCA { get; set; }

    public string poliza { get; set; } = null!;

    public int cve_cuentaBco { get; set; }

    public string? Num_CuentaBco { get; set; }

    public DateTime? FechaComp { get; set; }

    public decimal? PorcIVA { get; set; }
}
