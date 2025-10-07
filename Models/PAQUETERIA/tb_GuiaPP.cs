using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_GuiaPP
{
    public long cve_Guia { get; set; }

    public string num_Guia { get; set; } = null!;

    public double? recoleccion { get; set; }

    public double? entrega { get; set; }

    public double? OtrosCargos { get; set; }

    public double? Flete { get; set; }

    public double? Seguro { get; set; }

    public double? CargoCita { get; set; }

    public double? ManDes { get; set; }

    public double? ManEst { get; set; }

    public double? DescFlete { get; set; }

    public double? IVA { get; set; }

    public double? RetIVA { get; set; }

    public double? Total { get; set; }

    public long? cve_GuiaPP { get; set; }

    public string? num_GuiaPP { get; set; }

    public long? ConsecPP { get; set; }

    public bool? usada { get; set; }
}
