using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbSerieFolio
{
    public int CveSerie { get; set; }

    public long FolioInicial { get; set; }

    public long FolioFinal { get; set; }

    public long? NumeroAprobacion { get; set; }

    public int? AnoAprobacion { get; set; }

    public DateTime? FechaAprobacion { get; set; }

    public string? HoraAprobacion { get; set; }
}
