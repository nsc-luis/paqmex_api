using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbTempDetGuium
{
    public long CveTempDetGuia { get; set; }

    public int? Cantidad { get; set; }

    public double? Kgs { get; set; }

    public int? CveEmpaque { get; set; }

    public string? DescEmpaque { get; set; }

    public string? Contenido { get; set; }

    public byte? Tipo { get; set; }

    public double? Largo { get; set; }

    public double? Alto { get; set; }

    public double? Ancho { get; set; }

    public byte? Renglon { get; set; }

    public string? Contenido2 { get; set; }

    public double? ImporteIva { get; set; }

    public string? CveSatProdCartaPorteSat { get; set; }

    public string? DescProdCartaPorteSat { get; set; }

    public string? CveSatUniMedSat { get; set; }

    public string? MatPeligroso { get; set; }
}
