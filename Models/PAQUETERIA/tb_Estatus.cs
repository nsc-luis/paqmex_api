using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_Estatus
{
    public int Cve_estatus { get; set; }

    public string desc_estatus { get; set; } = null!;

    public bool contrarecibo { get; set; }

    public bool diario { get; set; }

    public byte tipo { get; set; }

    public bool Conciliacion { get; set; }

    public bool Duplica { get; set; }

    public bool? Cobranza { get; set; }

    public byte? Tipo2 { get; set; }

    public byte? Grupo { get; set; }

    public string? DescInternet { get; set; }

    public bool? DespInternet { get; set; }

    public bool? PorRev { get; set; }

    public int? Cve_OfiRev { get; set; }

    public bool? HabilitaCap { get; set; }

    public int? OrdenCD { get; set; }

    public byte? TipoCte { get; set; }

    public bool? PagoInd { get; set; }

    public bool? PagoRefe { get; set; }

    public bool? REQUIEREAUT { get; set; }
}
