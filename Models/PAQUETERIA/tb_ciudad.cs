using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_ciudad
{
    public int Cve_ciudad { get; set; }

    public int Cve_estado { get; set; }

    public string nom_ciudad { get; set; } = null!;

    public int? Cve_estatus { get; set; }

    public bool? ACTIVO { get; set; }

    public byte? REGION { get; set; }

    public int? GpoConvenio { get; set; }

    public bool? ENTREGA { get; set; }

    public bool? EntregaInt { get; set; }

    public bool? ocurre { get; set; }

    public byte? cve_DesTarKgs { get; set; }

    public int? cve_DestinoConv { get; set; }

    public double? CargoGuia { get; set; }

    public int? cve_ofiCiudad { get; set; }

    public string? LATITUD { get; set; }

    public string? LONGITUD { get; set; }

    public bool? MapaWeb { get; set; }

    public string? NombreMapaWeb { get; set; }

    public bool? EntregaCte { get; set; }
}
