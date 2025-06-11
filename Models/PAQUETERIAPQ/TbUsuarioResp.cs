using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbUsuarioResp
{
    public short CveUsuario { get; set; }

    public string Usuario { get; set; } = null!;

    public string NomUsuario { get; set; } = null!;

    public string Pasword { get; set; } = null!;

    public string? Titulo { get; set; }

    public int? CveRol { get; set; }

    public byte CveDepto { get; set; }

    public int? CveOfiDest { get; set; }

    public int? CveOfiCred { get; set; }

    public int? CveAgeVta { get; set; }

    public int? CveEjeCta { get; set; }

    public int? CveRolcon { get; set; }

    public string? TodosEstatus { get; set; }

    public int? CveOficina { get; set; }

    public string? CveAutoriza { get; set; }

    public bool? Agevta { get; set; }

    public bool? Ejecta { get; set; }

    public int? CveRoliso { get; set; }

    public int? CveEmpleado { get; set; }

    public bool? AvisarFolios { get; set; }

    public bool? AgeActivo { get; set; }

    public bool? Activo { get; set; }

    public int? CveOfiMain { get; set; }

    public bool? EjeCtaRec { get; set; }

    public bool? EjeCtaVta { get; set; }

    public int? Bloque { get; set; }

    public string? Email { get; set; }

    public bool? MostrarRecol { get; set; }

    public string? CuentasCob { get; set; }

    public bool? PagosDiaAct { get; set; }

    public bool? PagosMesAnt { get; set; }

    public int? CveUsuPaqmex { get; set; }

    public bool? BloqueaPaq { get; set; }

    public bool? BloqueaTaller { get; set; }

    public bool? BloqueaTrafico { get; set; }

    public bool? BloqueaIso { get; set; }

    public bool? BloqueaFacElec { get; set; }

    public bool? BloqueaContab { get; set; }
}
