using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_TarifaCteDUPLICA
{
    public long cve_tarifa { get; set; }

    public long cve_cliente { get; set; }

    public int cve_oficinaOri { get; set; }

    public int cve_OficinaDes { get; set; }

    public int? cve_empaque { get; set; }

    public byte Tipo { get; set; }

    public double tarifa { get; set; }

    public DateTime? VIGENCIA { get; set; }

    public DateTime? FechaAlta { get; set; }

    public byte? TipoCarga { get; set; }

    public int? DESTINOANT { get; set; }

    public double? Minimo { get; set; }

    public bool? ACTIVO { get; set; }
}
