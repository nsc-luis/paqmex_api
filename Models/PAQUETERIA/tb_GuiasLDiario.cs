using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_GuiasLDiario
{
    public int anio { get; set; }

    public byte mes { get; set; }

    public string num_guia { get; set; } = null!;
}
