using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbTarifaKmsLiq
{
    public int CveTarifa { get; set; }

    public int KmsIni { get; set; }

    public int KmsFin { get; set; }

    public double Tarifa { get; set; }
}
