using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbDiasEntrega
{
    public int CveOficinaOri { get; set; }

    public int CveOficinaDes { get; set; }

    public int? Dias { get; set; }
}
