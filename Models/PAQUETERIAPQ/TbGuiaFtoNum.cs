using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbGuiaFtoNum
{
    public long CveGuia { get; set; }

    public string? NumGuia { get; set; }

    public string? CadenaOriginal { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string? CadenaOriginalNew { get; set; }

    public string? Sello { get; set; }

    public string? SelloNew { get; set; }
}
