using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbPrograma
{
    public int CvePrograma { get; set; }

    public string NomPrograma { get; set; } = null!;

    public string? Notas { get; set; }

    public short Modulo { get; set; }

    public short Orden { get; set; }

    public bool Activo { get; set; }

    public string Tipo { get; set; } = null!;

    public bool? Admin { get; set; }

    public int? CveOfiCred { get; set; }

    public int? CveZona { get; set; }

    public string? Prefijo { get; set; }

    public int? CveOficina { get; set; }

    public bool? Exclusivo { get; set; }

    public bool? Impresion { get; set; }

    public int? Modulo2 { get; set; }

    public string? PrefijoFacElec { get; set; }

    public bool? AsignaOfiRep { get; set; }
}
