using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbTarifaCitum
{
    public int CveTarifa { get; set; }

    public byte CveOficina { get; set; }

    public int PesoIni { get; set; }

    public int PesoFin { get; set; }

    public double Tarifa { get; set; }
}
