using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_CamionMttoProg
{
    public int Cve_camion { get; set; }

    public int cve_Paquete { get; set; }

    public double? KmMtto { get; set; }

    public double? KmAviso { get; set; }
}
