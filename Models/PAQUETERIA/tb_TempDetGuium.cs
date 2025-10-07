using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_TempDetGuium
{
    public long cve_tempDetGuia { get; set; }

    public int? cantidad { get; set; }

    public double? kgs { get; set; }

    public int? cve_empaque { get; set; }

    public string? desc_empaque { get; set; }

    public string? contenido { get; set; }

    public byte? tipo { get; set; }

    public double? Largo { get; set; }

    public double? Alto { get; set; }

    public double? Ancho { get; set; }

    public byte? renglon { get; set; }

    public string? CONtenido2 { get; set; }

    public double? ImporteIva { get; set; }

    public string? cveSAT_ProdCartaPorteSAT { get; set; }

    public string? desc_ProdCartaPorteSAT { get; set; }

    public string? cveSAT_UniMedSAT { get; set; }

    public string? MatPeligroso { get; set; }
}
