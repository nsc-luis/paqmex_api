using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbKmsEntrega
{
    public int CveOficinaOri { get; set; }

    public int CveCiudadDes { get; set; }

    public int? Kms { get; set; }
}
