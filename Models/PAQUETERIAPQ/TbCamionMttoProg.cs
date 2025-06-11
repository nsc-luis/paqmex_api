using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbCamionMttoProg
{
    public int CveCamion { get; set; }

    public int CvePaquete { get; set; }

    public double? KmMtto { get; set; }

    public double? KmAviso { get; set; }
}
