using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbTarifaPaq
{
    public int CveTarifa { get; set; }

    public int CveOfiOri { get; set; }

    public int CveOfiDes { get; set; }

    public int PesoIni { get; set; }

    public int PesoFin { get; set; }

    public byte Tipo { get; set; }

    public double Tarifa { get; set; }
}
