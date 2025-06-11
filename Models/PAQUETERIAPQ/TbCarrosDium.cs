using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbCarrosDium
{
    public string Prefijo { get; set; } = null!;

    public int Anio { get; set; }

    public short Mes { get; set; }

    public short Dia { get; set; }

    public short Carros { get; set; }
}
