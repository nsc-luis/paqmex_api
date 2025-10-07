using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_MotivoCancela
{
    public int cve_motivo { get; set; }

    public string? desc_motivo { get; set; }

    public bool? activo { get; set; }

    public bool? CancelaDirecto { get; set; }
}
