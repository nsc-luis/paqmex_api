using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbConcepto
{
    public int CveConcepto { get; set; }

    public string DescConcepto { get; set; } = null!;

    public string? CuentaContable { get; set; }

    public bool? Diesel { get; set; }

    public bool? Desglose { get; set; }

    public byte? NivelAfecta { get; set; }

    public bool? Sueldo { get; set; }

    public bool? CargoAbono { get; set; }

    public bool? Tipo { get; set; }

    public bool? GastoRep { get; set; }

    public int? CveOficina { get; set; }

    public bool? GastoSal { get; set; }

    public int? CveProveedor { get; set; }

    public bool? Prestamo { get; set; }

    public double? Orden { get; set; }

    public bool? Deduccion { get; set; }
}
