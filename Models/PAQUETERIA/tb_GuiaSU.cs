using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_GuiaSU
{
    public long cve_guiaCAN { get; set; }

    public long cve_guiaSUS { get; set; }

    public string? num_guiaCAN { get; set; }

    public string? num_guiaSUS { get; set; }

    public byte? Causacancela { get; set; }

    public int? cve_UsuAudita { get; set; }

    public string? nom_UsuAudita { get; set; }

    public DateOnly? fecha_Audita { get; set; }

    public bool? OtroMes { get; set; }

    public string? descripcion { get; set; }

    public long? cve_guiaestatus { get; set; }

    public bool? AUDITADO { get; set; }

    public DateTime? FechaCaptura { get; set; }

    public byte? Tipo { get; set; }

    public bool? Revisado { get; set; }

    public string? nom_UsuREVISA { get; set; }

    public DateOnly? fecha_REVISA { get; set; }

    public int? cve_Usuario { get; set; }

    public string? nom_Usuario { get; set; }
}
