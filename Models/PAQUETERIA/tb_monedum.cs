using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_monedum
{
    public short Cve_moneda { get; set; }

    public string desc_moneda { get; set; } = null!;

    public string simbolo { get; set; } = null!;

    public string idioma { get; set; } = null!;

    public string terminacion { get; set; } = null!;

    public string LeyendaSingular { get; set; } = null!;

    public string LeyendaPlural { get; set; } = null!;

    public double TipoCambio { get; set; }
}
