using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_ClienteConvKg
{
    public long cve_cliente { get; set; }

    public DateOnly Vigencia { get; set; }

    public bool Activo { get; set; }

    public double? CompromisoFte { get; set; }

    public double? CompromisoKgs { get; set; }

    public DateTime? FechaAlta { get; set; }

    public bool? Revisado { get; set; }

    public int? cve_usuario { get; set; }

    public string? nom_usuario { get; set; }

    public DateOnly? FechaReactiva { get; set; }

    public byte? Tipo { get; set; }

    public byte? CLASIF { get; set; }
}
