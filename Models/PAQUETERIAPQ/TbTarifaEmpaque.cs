using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbTarifaEmpaque
{
    public long CveTarifa { get; set; }

    public int CveOficinaOri { get; set; }

    public int CveOficinaDes { get; set; }

    public int? CveEmpaque { get; set; }

    public double Tarifa { get; set; }

    public byte? TipoCarga { get; set; }

    public double? Minimo { get; set; }

    public DateTime? FechaAlta { get; set; }
}
