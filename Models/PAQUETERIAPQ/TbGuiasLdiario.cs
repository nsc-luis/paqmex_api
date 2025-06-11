using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbGuiasLdiario
{
    public int Anio { get; set; }

    public byte Mes { get; set; }

    public string NumGuia { get; set; } = null!;
}
