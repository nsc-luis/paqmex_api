using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_Guia_FtoNum
{
    public long cve_Guia { get; set; }

    public string? num_Guia { get; set; }

    public string? cadenaOriginal { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string? cadenaOriginalNEW { get; set; }

    public string? Sello { get; set; }

    public string? SelloNew { get; set; }
}
