using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbOficinaPrefijo
{
    public byte CveOficina { get; set; }

    public byte CveOficinaDest { get; set; }

    public int CveSerie { get; set; }
}
