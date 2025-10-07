using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_TempGuiasCtrlD
{
    public long cve_TempGuiasCtrlD { get; set; }

    public long? CVE_GUIA { get; set; }

    public DateTime? FECHAALTA { get; set; }

    public string? NUM_GUIA { get; set; }

    public int? CVE_ESTATUS { get; set; }

    public string? DESC_ESTATUS { get; set; }

    public int? cve_ciudadDes { get; set; }

    public string? prefijo { get; set; }

    public long? consec { get; set; }

    public byte? CONDPAGO { get; set; }

    public double? Total { get; set; }

    public byte? FormaPago { get; set; }

    public string? CiudadDes { get; set; }

    public int? Dias { get; set; }

    public long? cve_guiaestatus { get; set; }
}
