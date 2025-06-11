using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbClienteAgeVtum
{
    public long CveCliente { get; set; }

    public int CveAgeVta { get; set; }

    public DateOnly Fecha { get; set; }

    public int CveUsuAsigna { get; set; }

    public string NomUsuAsigna { get; set; } = null!;
}
