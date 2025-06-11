using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbEstatusTr
{
    public int CveEstatus { get; set; }

    public string DescEstatus { get; set; } = null!;

    public byte Tipo { get; set; }

    public byte? ACtivo { get; set; }
}
