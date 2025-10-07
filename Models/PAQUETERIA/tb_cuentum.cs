using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_cuentum
{
    public byte Cve_cuenta { get; set; }

    public string tipo_cuenta { get; set; } = null!;

    public string numero_cuenta { get; set; } = null!;

    public byte cve_moneda { get; set; }

    public byte? cve_banco { get; set; }

    public byte? cve_sucursal { get; set; }

    public string leyenda { get; set; } = null!;

    public string? formato { get; set; }

    public string? telefono { get; set; }

    public int? siguiente_cheque { get; set; }

    public double saldo_inicial { get; set; }

    public double total_cargos { get; set; }

    public double total_abonos { get; set; }

    public double saldo_conciliado { get; set; }

    public double saldo_actual { get; set; }

    public string? nombre { get; set; }

    public double total_cargosTR { get; set; }

    public double total_abonosTR { get; set; }

    public string? cuenta_contable { get; set; }
}
