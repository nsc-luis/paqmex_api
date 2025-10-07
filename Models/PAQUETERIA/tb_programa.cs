using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_programa
{
    public int Cve_programa { get; set; }

    public string nom_programa { get; set; } = null!;

    public string? notas { get; set; }

    public short modulo { get; set; }

    public short orden { get; set; }

    public bool activo { get; set; }

    public string tipo { get; set; } = null!;

    public bool? ADMIN { get; set; }

    public int? cve_OfiCred { get; set; }

    public int? cve_zona { get; set; }

    public string? PREFIJO { get; set; }

    public int? cve_OFICINA { get; set; }

    public bool? EXCLUSIVO { get; set; }

    public bool? Impresion { get; set; }

    public int? MODULO2 { get; set; }

    public string? PrefijoFacElec { get; set; }

    public bool? AsignaOfiRep { get; set; }
}
