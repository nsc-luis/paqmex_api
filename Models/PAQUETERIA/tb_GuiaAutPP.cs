using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_GuiaAutPP
{
    public long cve_guia { get; set; }

    public DateOnly fecha { get; set; }

    public string nom_usuario { get; set; } = null!;

    public byte Tipo { get; set; }
}
