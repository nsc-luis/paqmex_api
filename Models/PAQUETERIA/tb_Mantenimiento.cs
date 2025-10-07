using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_Mantenimiento
{
    public long cve_Mantenimiento { get; set; }

    public int cve_Camion { get; set; }

    public int cve_Paquete { get; set; }

    public DateTime Fecha { get; set; }

    public string? NumOrden { get; set; }

    public double? kms { get; set; }

    public byte? TIPO { get; set; }
}
