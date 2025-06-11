using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbGuiaPp
{
    public long CveGuia { get; set; }

    public string NumGuia { get; set; } = null!;

    public double? Recoleccion { get; set; }

    public double? Entrega { get; set; }

    public double? OtrosCargos { get; set; }

    public double? Flete { get; set; }

    public double? Seguro { get; set; }

    public double? CargoCita { get; set; }

    public double? ManDes { get; set; }

    public double? ManEst { get; set; }

    public double? DescFlete { get; set; }

    public double? Iva { get; set; }

    public double? RetIva { get; set; }

    public double? Total { get; set; }

    public long? CveGuiaPp { get; set; }

    public string? NumGuiaPp { get; set; }

    public long? ConsecPp { get; set; }

    public bool? Usada { get; set; }
}
