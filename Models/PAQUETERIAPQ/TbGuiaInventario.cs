using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbGuiaInventario
{
    public long CveGuia { get; set; }

    public DateTime FechaInv { get; set; }

    public string? NumGuia { get; set; }

    public int? CveUsuario { get; set; }

    public string? NomUsuario { get; set; }

    public int? CveOficina { get; set; }

    public string? Observaciones { get; set; }
}
