using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbClienteConvKgsResp
{
    public long CveCliente { get; set; }

    public DateOnly Vigencia { get; set; }

    public bool Activo { get; set; }

    public double? CompromisoFte { get; set; }

    public double? CompromisoKgs { get; set; }

    public DateTime? FechaAlta { get; set; }

    public bool? Revisado { get; set; }

    public int? CveUsuario { get; set; }

    public string? NomUsuario { get; set; }
}
