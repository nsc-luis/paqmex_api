using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbTarifa
{
    public int CveTarifa { get; set; }

    public int? CveOficina { get; set; }

    public int PesoIni { get; set; }

    public int PesoFin { get; set; }

    public double Recoleccion { get; set; }

    public double Entrega { get; set; }
}
