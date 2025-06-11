using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbClienteEmbarque
{
    public long CveEmbarque { get; set; }

    public long CveCliente { get; set; }

    public string Direccion { get; set; } = null!;

    public string? Colonia { get; set; }

    public string? Cp { get; set; }

    public int CveCiudad { get; set; }

    public int CveEstado { get; set; }

    public string? Tel1 { get; set; }

    public string? Tel2 { get; set; }

    public bool Foranea { get; set; }

    public int? CveColonia { get; set; }

    public int? CveDireccion { get; set; }

    public string? NumExt { get; set; }

    public string? NumInt { get; set; }

    public string? CveSatColonia { get; set; }

    public string? CveSatLocalidad { get; set; }

    public string? CveSatMunicipio { get; set; }

    public string? CveSatEstado { get; set; }
}
