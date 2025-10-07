using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_GuiaPago
{
    public long cve_guia { get; set; }

    public string? referencia { get; set; }

    public int? cve_banco { get; set; }

    public string? nom_banco { get; set; }

    public byte? FormaPago { get; set; }

    public string? CuentaChq { get; set; }
}
