using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbCuentum
{
    public byte CveCuenta { get; set; }

    public string TipoCuenta { get; set; } = null!;

    public string NumeroCuenta { get; set; } = null!;

    public byte CveMoneda { get; set; }

    public byte? CveBanco { get; set; }

    public byte? CveSucursal { get; set; }

    public string Leyenda { get; set; } = null!;

    public string? Formato { get; set; }

    public string? Telefono { get; set; }

    public int? SiguienteCheque { get; set; }

    public double SaldoInicial { get; set; }

    public double TotalCargos { get; set; }

    public double TotalAbonos { get; set; }

    public double SaldoConciliado { get; set; }

    public double SaldoActual { get; set; }

    public string? Nombre { get; set; }

    public double TotalCargosTr { get; set; }

    public double TotalAbonosTr { get; set; }

    public string? CuentaContable { get; set; }
}
