using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbEmpaque
{
    public int CveEmpaque { get; set; }

    public string DescEmpaque { get; set; } = null!;

    public double? Alto { get; set; }

    public double? Ancho { get; set; }

    public double? Largo { get; set; }

    public double? Preciomin { get; set; }

    public double? Pesomin { get; set; }

    public string? Codigo { get; set; }

    public double? Peso { get; set; }

    public double? PesoMax { get; set; }

    public bool? Desplegar { get; set; }

    public bool? Activo { get; set; }

    public bool? ValidaPesoDoc { get; set; }

    public byte? Tipo { get; set; }

    public double? PesoDocUnEmpaque { get; set; }
}
