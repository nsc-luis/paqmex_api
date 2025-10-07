using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_TarifaPQ
{
    public int cve_origen { get; set; }

    public int cve_destino { get; set; }

    public double Tarifa { get; set; }
}
