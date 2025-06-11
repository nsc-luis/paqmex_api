using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbGuiaAutSu
{
    public long? CveGuiaAutSus { get; set; }

    public long? CveGuia { get; set; }

    public byte? CausaCancela { get; set; }

    public int? CveUsuario { get; set; }

    public DateTime? FechaAutoriza { get; set; }

    public string? NomUsuario { get; set; }

    public string? NumGuia { get; set; }
}
