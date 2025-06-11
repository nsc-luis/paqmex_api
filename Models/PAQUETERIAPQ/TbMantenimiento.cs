using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbMantenimiento
{
    public long CveMantenimiento { get; set; }

    public int CveCamion { get; set; }

    public int CvePaquete { get; set; }

    public DateTime Fecha { get; set; }

    public string? NumOrden { get; set; }

    public double? Kms { get; set; }

    public byte? Tipo { get; set; }
}
