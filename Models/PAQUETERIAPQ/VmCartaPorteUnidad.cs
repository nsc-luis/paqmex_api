using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class VmCartaPorteUnidad
{
    public int IdUnidad { get; set; }

    public string NombreUnidad { get; set; } = null!;

    public int CveOperador { get; set; }

    public string? Marca { get; set; }

    public string? Modelo { get; set; }

    public string? Serie { get; set; }

    public string? Placa { get; set; }

    public int? Ejes { get; set; }

    public string Aseguradora { get; set; } = null!;

    public string? NoPoliza { get; set; }

    public int? CveTipoCarroSat { get; set; }

    public string ConfigVehicular { get; set; } = null!;

    public string? NumPermisoSct { get; set; }

    public string? PermSct { get; set; }
}
