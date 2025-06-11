using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbCiudad
{
    public int CveCiudad { get; set; }

    public int CveEstado { get; set; }

    public string NomCiudad { get; set; } = null!;

    public int? CveEstatus { get; set; }

    public bool? Activo { get; set; }

    public byte? Region { get; set; }

    public int? GpoConvenio { get; set; }

    public bool? Entrega { get; set; }

    public bool? EntregaInt { get; set; }

    public bool? Ocurre { get; set; }

    public byte? CveDesTarKgs { get; set; }

    public int? CveDestinoConv { get; set; }

    public double? CargoGuia { get; set; }

    public int? CveOfiCiudad { get; set; }

    public string? Latitud { get; set; }

    public string? Longitud { get; set; }

    public bool? MapaWeb { get; set; }

    public string? NombreMapaWeb { get; set; }

    public bool? EntregaCte { get; set; }
}
