using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_UuidPac
{
    public string uuid { get; set; } = null!;

    public DateTime fechaAlta { get; set; }

    public DateTime? FechaTimbre { get; set; }

    public string? Datos { get; set; }

    public int? EstatusCancela { get; set; }

    public string? desc_EstatusCancela { get; set; }

    public DateTime? FechaCancela { get; set; }

    public string? AcuseCancela { get; set; }
}
