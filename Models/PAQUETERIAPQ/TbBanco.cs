using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbBanco
{
    public byte CveBanco { get; set; }

    public string NomBanco { get; set; } = null!;

    public string NomLargo { get; set; } = null!;
}
