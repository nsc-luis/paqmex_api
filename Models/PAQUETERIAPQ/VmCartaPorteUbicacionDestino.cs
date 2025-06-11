using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class VmCartaPorteUbicacionDestino
{
    public int? IdUbicacion { get; set; }

    public string NombreUbicacion { get; set; } = null!;

    public string Calle { get; set; } = null!;

    public string? CodigoPostal { get; set; }

    public string? Colonia { get; set; }

    public string? Estado { get; set; }

    public string? Localidad { get; set; }

    public string? Municipio { get; set; }

    public string? NumeroExterior { get; set; }

    public string Pais { get; set; } = null!;

    public string TipoUbicacion { get; set; } = null!;
}
