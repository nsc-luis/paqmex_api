using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.ENTREGAS;

public partial class tb_archivos_entrega_tipo
{
    public int cve_tipo { get; set; }

    public string? nombre_tipo { get; set; }

    public DateTime? fecha_creacion { get; set; }

    public DateTime? fecha_modificacion { get; set; }

    public int? orden { get; set; }

    public byte? estatus { get; set; }
}
