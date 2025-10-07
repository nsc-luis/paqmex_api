using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_banco
{
    public byte Cve_banco { get; set; }

    public string nom_banco { get; set; } = null!;

    public string nom_largo { get; set; } = null!;
}
