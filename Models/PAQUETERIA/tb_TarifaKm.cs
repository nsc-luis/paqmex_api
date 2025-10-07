using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_TarifaKm
{
    public int cve_tarifa { get; set; }

    public byte Tipo { get; set; }

    public int KmsIni { get; set; }

    public int KmsFin { get; set; }

    public double Tarifa { get; set; }
}
