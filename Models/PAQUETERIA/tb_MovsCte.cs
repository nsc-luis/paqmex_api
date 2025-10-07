using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_MovsCte
{
    public long Cve_mov { get; set; }

    public long cve_cliente { get; set; }

    public byte cve_oficina { get; set; }

    public long cve_guia { get; set; }

    public int cve_concepto { get; set; }

    public string descripcion { get; set; } = null!;

    public DateTime fecha { get; set; }

    public double Importe { get; set; }

    public string TipoMov { get; set; } = null!;
}
