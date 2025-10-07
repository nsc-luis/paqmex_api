using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class vmCartaPorteUnidad
{
    public int IdUnidad { get; set; }

    public string NombreUnidad { get; set; } = null!;

    public int cve_Operador { get; set; }

    public string? Marca { get; set; }

    public string? Modelo { get; set; }

    public string? Serie { get; set; }

    public string? Placa { get; set; }

    public int? Ejes { get; set; }

    public string Aseguradora { get; set; } = null!;

    public string? NoPoliza { get; set; }

    public int? cve_TipoCarroSAT { get; set; }

    public string ConfigVehicular { get; set; } = null!;

    public string? NumPermisoSCT { get; set; }

    public string? PermSCT { get; set; }
}
