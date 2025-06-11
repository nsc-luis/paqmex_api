using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbGuiaSu
{
    public long CveGuiaCan { get; set; }

    public long CveGuiaSus { get; set; }

    public string? NumGuiaCan { get; set; }

    public string? NumGuiaSus { get; set; }

    public byte? Causacancela { get; set; }

    public int? CveUsuAudita { get; set; }

    public string? NomUsuAudita { get; set; }

    public DateOnly? FechaAudita { get; set; }

    public bool? OtroMes { get; set; }

    public string? Descripcion { get; set; }

    public long? CveGuiaestatus { get; set; }

    public bool? Auditado { get; set; }

    public DateTime? FechaCaptura { get; set; }

    public byte? Tipo { get; set; }

    public bool? Revisado { get; set; }

    public string? NomUsuRevisa { get; set; }

    public DateOnly? FechaRevisa { get; set; }

    public int? CveUsuario { get; set; }

    public string? NomUsuario { get; set; }
}
