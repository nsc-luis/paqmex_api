using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_usuario
{
    public short Cve_usuario { get; set; }

    public string usuario { get; set; } = null!;

    public string nom_usuario { get; set; } = null!;

    public string pasword { get; set; } = null!;

    public string? titulo { get; set; }

    public int? cve_rol { get; set; }

    public byte cve_depto { get; set; }

    public int? Cve_OfiDest { get; set; }

    public int? Cve_OfiCred { get; set; }

    public int? Cve_AgeVta { get; set; }

    public int? cve_EjeCta { get; set; }

    public int? CVE_ROLCON { get; set; }

    public string? TodosEstatus { get; set; }

    public int? cve_oficina { get; set; }

    public string? CveAutoriza { get; set; }

    public bool? AGEVTA { get; set; }

    public bool? EJECTA { get; set; }

    public int? CVE_ROLISO { get; set; }

    public int? cve_empleado { get; set; }

    public bool? AvisarFolios { get; set; }

    public bool? AgeActivo { get; set; }

    public bool? Activo { get; set; }

    public int? cve_OfiMain { get; set; }

    public bool? EjeCtaRec { get; set; }

    public bool? EjeCtaVta { get; set; }

    public int? bloque { get; set; }

    public string? email { get; set; }

    public bool? MostrarRecol { get; set; }

    public string? cuentasCob { get; set; }

    public bool? PagosDiaAct { get; set; }

    public bool? PagosMesAnt { get; set; }

    public int? cve_UsuPaqmex { get; set; }

    public bool? bloqueaPaq { get; set; }

    public bool? bloqueaTaller { get; set; }

    public bool? bloqueaTrafico { get; set; }

    public bool? bloqueaISO { get; set; }

    public bool? bloqueaFacElec { get; set; }

    public bool? bloqueaContab { get; set; }

    public bool? EjeAtnCtes { get; set; }

    public string? Iniciales { get; set; }

    public DateTime? FechaAlta { get; set; }

    public long? CVE_CLIENTE { get; set; }

    public int? cve_OfiISO { get; set; }

    public int? cve_OfiREV { get; set; }

    public bool? EjeCob { get; set; }

    public string? UsuarioBaja { get; set; }

    public DateTime? FechaBaja { get; set; }

    public double? ComisionVta { get; set; }

    public double? SueldoBase { get; set; }

    public bool? CargaPagosBanco { get; set; }

    public bool? EjeCtaVtaActivo { get; set; }

    public int? CVE_ROLISOANT { get; set; }

    public bool? AUDITORISO1 { get; set; }

    public bool? AUDITORISO2 { get; set; }

    public bool? AuditorISOC { get; set; }

    public int? CVE_OPERADOR { get; set; }

    public bool? ActGuiaRep { get; set; }

    public string? DirectorioOC { get; set; }

    public bool? TodoDirOC { get; set; }

    public byte? Nivel { get; set; }
}
