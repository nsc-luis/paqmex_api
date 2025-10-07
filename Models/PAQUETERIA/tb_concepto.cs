using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_concepto
{
    public int Cve_concepto { get; set; }

    public string desc_concepto { get; set; } = null!;

    public string? cuenta_contable { get; set; }

    public bool? Diesel { get; set; }

    public bool? Desglose { get; set; }

    public byte? NivelAfecta { get; set; }

    public bool? Sueldo { get; set; }

    public bool? CargoAbono { get; set; }

    public bool? Tipo { get; set; }

    public bool? GastoRep { get; set; }

    public int? cve_oficina { get; set; }

    public bool? GastoSal { get; set; }

    public int? cve_proveedor { get; set; }

    public bool? PRESTAMO { get; set; }

    public double? ORDEN { get; set; }

    public bool? DEDUCCION { get; set; }
}
