using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbGuiaDetalle
{
    public long CveGuiaDet { get; set; }

    public long CveGuia { get; set; }

    public byte Renglon { get; set; }

    public byte? Tipo { get; set; }

    public double? Kgs { get; set; }

    public int? CveEmpaque { get; set; }

    public string? DescEmpaque { get; set; }

    public string? Contenido { get; set; }

    public int? Cantidad { get; set; }

    public string? Contenido2 { get; set; }

    public string? CveSatProdCartaPorteSat { get; set; }

    public string? DescProdCartaPorteSat { get; set; }

    public string? CveSatUniMedSat { get; set; }

    public string? MatPeligroso { get; set; }
}
