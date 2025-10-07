using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.JPG;

public partial class registroConsulta
{
    public int idRegistro { get; set; }

    public string consulta { get; set; } = null!;

    public string parametrosDeConsulta { get; set; } = null!;

    public DateTime timestamp { get; set; }
}
