using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_NotaCredito
{
    public int cve_NotaCredito { get; set; }

    public long? ConsecNC { get; set; }

    public string desc_NotaCredito { get; set; } = null!;

    public double Importe { get; set; }

    public int cve_cliente { get; set; }

    public string nom_cliente { get; set; } = null!;

    public DateTime fecha { get; set; }

    public int cve_usuario { get; set; }

    public string nom_usuario { get; set; } = null!;

    public bool Tipo { get; set; }

    public DateTime FechaPago { get; set; }

    public string direccion { get; set; } = null!;

    public string colonia { get; set; } = null!;

    public string poblacion { get; set; } = null!;

    public string rfc { get; set; } = null!;
}
