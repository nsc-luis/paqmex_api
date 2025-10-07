using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.ENTREGAS;

public partial class tb_firmas_entrega
{
    public long cve_empresa { get; set; }

    public long cve_guia { get; set; }

    public long? cve_usuario { get; set; }

    public string? firma_recibido { get; set; }

    public byte[]? firma_imagen { get; set; }

    public DateTime? fecha_creacion { get; set; }

    public DateTime? fecha_modificacion { get; set; }

    public byte? estatus { get; set; }
}
