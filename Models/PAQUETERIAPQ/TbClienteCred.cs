using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbClienteCred
{
    public long? CveCliente { get; set; }

    public DateTime? FechaCred { get; set; }

    public byte? CondPago { get; set; }

    public int? CveUsuario { get; set; }

    public string? NomUsuario { get; set; }
}
