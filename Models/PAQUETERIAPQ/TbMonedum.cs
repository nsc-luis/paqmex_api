using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbMonedum
{
    public short CveMoneda { get; set; }

    public string DescMoneda { get; set; } = null!;

    public string Simbolo { get; set; } = null!;

    public string Idioma { get; set; } = null!;

    public string Terminacion { get; set; } = null!;

    public string LeyendaSingular { get; set; } = null!;

    public string LeyendaPlural { get; set; } = null!;

    public double TipoCambio { get; set; }
}
