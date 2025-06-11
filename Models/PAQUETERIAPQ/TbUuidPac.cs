using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbUuidPac
{
    public string Uuid { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaTimbre { get; set; }

    public string? Datos { get; set; }

    public int? EstatusCancela { get; set; }

    public string? DescEstatusCancela { get; set; }

    public DateTime? FechaCancela { get; set; }

    public string? AcuseCancela { get; set; }
}
