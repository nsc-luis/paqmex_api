using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbMovsCte
{
    public long CveMov { get; set; }

    public long CveCliente { get; set; }

    public byte CveOficina { get; set; }

    public long CveGuia { get; set; }

    public int CveConcepto { get; set; }

    public string Descripcion { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public double Importe { get; set; }

    public string TipoMov { get; set; } = null!;
}
