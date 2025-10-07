﻿using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_Serie
{
    public int Cve_serie { get; set; }

    public string prefijo_fac { get; set; } = null!;

    public long consec_fac { get; set; }

    public long? FolioInicial { get; set; }

    public long? FolioFinal { get; set; }

    public long? NumeroAprobacion { get; set; }

    public int? AnoAprobacion { get; set; }

    public DateTime? FechaAprobacion { get; set; }

    public string? HoraAprobacion { get; set; }

    public byte? TipoSerie { get; set; }

    public long? FolioInicial2 { get; set; }

    public long? FolioFinal2 { get; set; }

    public long? NumeroAprobacion2 { get; set; }

    public int? AnoAprobacion2 { get; set; }

    public DateTime? FechaAprobacion2 { get; set; }

    public string? HoraAprobacion2 { get; set; }

    public bool? NoSeccionar { get; set; }
}
