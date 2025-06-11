using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbGuiaAutPp
{
    public long CveGuia { get; set; }

    public DateOnly Fecha { get; set; }

    public string NomUsuario { get; set; } = null!;

    public byte Tipo { get; set; }
}
