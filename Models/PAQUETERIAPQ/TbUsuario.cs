using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbUsuario
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

    public bool? EjeAtnCtes { get; set; }

    public string? Iniciales { get; set; }

    public DateTime? FechaAlta { get; set; }

    public long? CveCliente { get; set; }

    public int? CveOfiIso { get; set; }

    public int? CveOfiRev { get; set; }

    public bool? EjeCob { get; set; }

    public string? UsuarioBaja { get; set; }

    public DateTime? FechaBaja { get; set; }

    public double? ComisionVta { get; set; }

    public double? SueldoBase { get; set; }

    public bool? CargaPagosBanco { get; set; }

    public bool? EjeCtaVtaActivo { get; set; }

    public bool? Auditoriso1 { get; set; }

    public bool? Auditoriso2 { get; set; }

    public bool? AuditorIsoc { get; set; }

    public int? CveOperador { get; set; }

    public bool? ActGuiaRep { get; set; }

    public string? DirectorioOc { get; set; }

    public bool? TodoDirOc { get; set; }

    public byte? Nivel { get; set; }
}
