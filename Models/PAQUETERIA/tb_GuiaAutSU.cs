using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_GuiaAutSU
{
    public long? cve_guiaAutSus { get; set; }

    public long? cve_guia { get; set; }

    public byte? CausaCancela { get; set; }

    public int? cve_usuario { get; set; }

    public DateTime? fechaAutoriza { get; set; }

    public string? nom_usuario { get; set; }

    public string? num_guia { get; set; }
}
