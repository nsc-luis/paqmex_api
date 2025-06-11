using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbGuiaCon
{
    public long CveGuiaCon { get; set; }

    public long CveGuia { get; set; }

    public string CveProd { get; set; } = null!;

    public int Cantidad { get; set; }

    public string CveUniMed { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public double ValorUni { get; set; }

    public double Importe { get; set; }

    public double? ImporteIva { get; set; }
}
