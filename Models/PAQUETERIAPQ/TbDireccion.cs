using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbDireccion
{
    public int CveDireccion { get; set; }

    public string Calle { get; set; } = null!;

    public string Cp { get; set; } = null!;

    public bool CargaAut { get; set; }

    public int CveCiudad { get; set; }

    public int CveEstado { get; set; }

    public int CveColonia { get; set; }

    public string? Cuadrante { get; set; }

    public string? Codzona { get; set; }

    public string? Codpostal { get; set; }

    public int? CveOperador { get; set; }

    public int? CveSupervisor { get; set; }

    public string? NomColonia { get; set; }
}
