using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_Foliador
{
    public int? TCve_Guia { get; set; }

    public int? TCve_DetGuia { get; set; }

    public int? TCve_Prog { get; set; }

    public int? TCve_Oficina { get; set; }

    public long? TCve_Maniobra { get; set; }

    public long? TCve_EmplHist { get; set; }

    public long? TCve_GuiaExp { get; set; }

    public long? tCve_ContraRecibo { get; set; }
}
