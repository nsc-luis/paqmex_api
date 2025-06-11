using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbColonium
{
    public int CveColonia { get; set; }

    public string NomColonia { get; set; } = null!;

    public string Cp { get; set; } = null!;

    public bool CargaAut { get; set; }

    public int CveCiudad { get; set; }

    public int CveEstado { get; set; }

    public string? Cuadrante { get; set; }

    public string? Codzona { get; set; }

    public string? Codpostal { get; set; }
}
