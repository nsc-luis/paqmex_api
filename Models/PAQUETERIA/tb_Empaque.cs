using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_Empaque
{
    public int Cve_empaque { get; set; }

    public string desc_empaque { get; set; } = null!;

    public double? alto { get; set; }

    public double? ancho { get; set; }

    public double? largo { get; set; }

    public double? PRECIOMIN { get; set; }

    public double? PESOMIN { get; set; }

    public string? codigo { get; set; }

    public double? PESO { get; set; }

    public double? pesoMax { get; set; }

    public bool? Desplegar { get; set; }

    public bool? activo { get; set; }

    public bool? ValidaPesoDoc { get; set; }

    public byte? Tipo { get; set; }

    public double? PesoDocUnEmpaque { get; set; }
}
