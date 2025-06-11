using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbTempGuiasCtrlD
{
    public long CveTempGuiasCtrlD { get; set; }

    public long? CveGuia { get; set; }

    public DateTime? Fechaalta { get; set; }

    public string? NumGuia { get; set; }

    public int? CveEstatus { get; set; }

    public string? DescEstatus { get; set; }

    public int? CveCiudadDes { get; set; }

    public string? Prefijo { get; set; }

    public long? Consec { get; set; }

    public byte? Condpago { get; set; }

    public double? Total { get; set; }

    public byte? FormaPago { get; set; }

    public string? CiudadDes { get; set; }

    public int? Dias { get; set; }

    public long? CveGuiaestatus { get; set; }
}
