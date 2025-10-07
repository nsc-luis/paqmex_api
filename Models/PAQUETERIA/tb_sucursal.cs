using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_sucursal
{
    public byte Cve_sucursal { get; set; }

    public byte cve_banco { get; set; }

    public string? num_sucursal { get; set; }

    public string nom_sucursal { get; set; } = null!;

    public string? telefono { get; set; }

    public string? contacto { get; set; }
}
