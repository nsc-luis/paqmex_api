using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_ClienteSdoVen
{
    public long cve_clientesdoVen { get; set; }

    public long cve_cliente { get; set; }

    public DateOnly fecha { get; set; }

    public bool SdoVen { get; set; }

    public string nom_usuario { get; set; } = null!;
}
