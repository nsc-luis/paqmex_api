using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.ENTREGAS;

public partial class TB_COMANDum
{
    public long cve_comanda { get; set; }

    public long? rampa { get; set; }

    public long? Camara { get; set; }

    public byte[]? foto { get; set; }

    public bool? recoleccion { get; set; }

    public int? cve_camion { get; set; }

    public int? cve_operador { get; set; }

    public string? nom_operador { get; set; }

    public bool? estibable { get; set; }

    public bool? MciaCondicion { get; set; }

    public string? Condiciones { get; set; }

    public int? cve_usuario { get; set; }

    public string? nom_usuario { get; set; }

    public DateTime? fecha { get; set; }
}
