using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_GuiaConTemp
{
    public long cve_GuiaCon { get; set; }

    public long cve_guia { get; set; }

    public string cve_Prod { get; set; } = null!;

    public int Cantidad { get; set; }

    public string cve_UniMed { get; set; } = null!;

    public string descripcion { get; set; } = null!;

    public double ValorUni { get; set; }

    public double Importe { get; set; }

    public string? num_guia { get; set; }

    public double? ImporteIVA { get; set; }
}
