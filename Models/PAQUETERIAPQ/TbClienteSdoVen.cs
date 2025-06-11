using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbClienteSdoVen
{
    public long CveClientesdoVen { get; set; }

    public long CveCliente { get; set; }

    public DateOnly Fecha { get; set; }

    public bool SdoVen { get; set; }

    public string NomUsuario { get; set; } = null!;
}
