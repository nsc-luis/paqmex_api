using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbEstatus
{
    public int CveEstatus { get; set; }

    public string DescEstatus { get; set; } = null!;

    public bool Contrarecibo { get; set; }

    public bool Diario { get; set; }

    public byte Tipo { get; set; }

    public bool Conciliacion { get; set; }

    public bool Duplica { get; set; }

    public bool? Cobranza { get; set; }

    public byte? Tipo2 { get; set; }

    public byte? Grupo { get; set; }

    public string? DescInternet { get; set; }

    public bool? DespInternet { get; set; }

    public bool? PorRev { get; set; }

    public int? CveOfiRev { get; set; }

    public bool? HabilitaCap { get; set; }

    public int? OrdenCd { get; set; }

    public byte? TipoCte { get; set; }

    public bool? PagoInd { get; set; }

    public bool? PagoRefe { get; set; }

    public bool? Requiereaut { get; set; }
}
