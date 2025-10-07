using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_CarrosDium
{
    public string prefijo { get; set; } = null!;

    public int anio { get; set; }

    public short mes { get; set; }

    public short dia { get; set; }

    public short carros { get; set; }
}
