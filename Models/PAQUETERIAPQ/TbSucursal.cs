using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbSucursal
{
    public byte CveSucursal { get; set; }

    public byte CveBanco { get; set; }

    public string? NumSucursal { get; set; }

    public string NomSucursal { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Contacto { get; set; }
}
