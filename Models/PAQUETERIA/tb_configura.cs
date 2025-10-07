using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_configura
{
    public string nombre { get; set; } = null!;

    public string direccion { get; set; } = null!;

    public string lugar { get; set; } = null!;

    public string representante_QUITAR { get; set; } = null!;

    public string? maniobras { get; set; }

    public double? IVA { get; set; }

    public double? RetIVA { get; set; }

    public double? RetISSS { get; set; }

    public double? RetIMSS { get; set; }

    public double? RendGasolina { get; set; }

    public double? SueldoPorKms { get; set; }

    public string? RFC_QUITAR { get; set; }

    public double? PorcVolumen { get; set; }

    public double? PorcDemora { get; set; }

    public double? PorcCitas { get; set; }

    public double? AltoCamion { get; set; }

    public double? AnchoCamion { get; set; }

    public double? LargoCamion { get; set; }

    public double? AltoCta { get; set; }

    public double? AnchoCta { get; set; }

    public double? LargoCta { get; set; }

    public string? keyCob { get; set; }

    public float? VERSION { get; set; }

    public string? LigaRepInt { get; set; }

    public string? PathFotoCaja { get; set; }

    public string? PathFotoEmp { get; set; }

    public double? FLETECTA { get; set; }

    public double? FLETECAMION { get; set; }

    public double? SueldoPorKmsPaq { get; set; }

    public string? MENSAJE { get; set; }

    public string? LinkRecol { get; set; }

    public double? FleteMetaLocal { get; set; }

    public double? FleteMetaForaneo { get; set; }

    public DateTime? FechaPagos { get; set; }

    public string? PwdCierrePagos { get; set; }

    public string? PwdAutLiq { get; set; }

    public string? PwdAutDiasV { get; set; }

    public string? PUERTO { get; set; }

    public string? pathGuias { get; set; }

    public bool? ENVIAFOLIOCAMARA { get; set; }

    public string? IMPRESORAETIQ { get; set; }

    public string? PUERTOUSB { get; set; }

    public string? ArchivoCer_QUITAR { get; set; }

    public string? archivoKEY_QUITAR { get; set; }

    public string? PasswordLlave_QUITAR { get; set; }

    public string? NumeroCertificado_QUITAR { get; set; }

    public string? Certificado_QUITAR { get; set; }

    public string? RFCCertificado_QUITAR { get; set; }

    public string? Logo_QUITAR { get; set; }

    public string? Cedula_QUITAR { get; set; }

    public string? NUMEXT_QUITAR { get; set; }

    public string? NUMINT_QUITAR { get; set; }

    public int? CVE_CIUDAD_QUITAR { get; set; }

    public string? NOM_CIUDAD_QUITAR { get; set; }

    public int? CVE_ESTADO_QUITAR { get; set; }

    public string? NOM_ESTADO_QUITAR { get; set; }

    public string? CP_QUITAR { get; set; }

    public string? COLONIA_QUITAR { get; set; }

    public bool? EnviaMailGuia { get; set; }

    public string? Logo2 { get; set; }

    public bool? SeriesFacElec { get; set; }

    public DateTime? VigenciaDesde_QUITAR { get; set; }

    public DateTime? VigenciaHasta_QUITAR { get; set; }

    public double? VersionFacElec { get; set; }

    public int? cve_CuentaCob { get; set; }

    public double? VersionTaller { get; set; }

    public string? VersionXML { get; set; }

    public double? VERSIOnTRA { get; set; }

    public string? mensajeIni { get; set; }

    public bool? AutPagoParcial { get; set; }

    public long? ConsecPP { get; set; }

    public string? tels_QUITAR { get; set; }

    public string? NomCorto { get; set; }

    public bool? PistasAut { get; set; }

    public double? VersionCtrlD { get; set; }

    public string? MsgIni { get; set; }

    public double? VersionDigitaliza { get; set; }

    public double? PorcProdQuim { get; set; }

    public long? cve_clienteTarMinCon { get; set; }

    public double? TipoCambio { get; set; }

    public DateOnly? FechaTipoCambio { get; set; }

    public bool? PwdPortal { get; set; }

    public double? PorcCPAC { get; set; }

    public bool? MostrarEntApp { get; set; }

    public byte? CopiasImpGuia { get; set; }

    public byte? MesesCapNDisel { get; set; }

    public byte? CVE_EMPRESA { get; set; }

    public string? nom_empresa { get; set; }

    public bool? Timbrar { get; set; }

    public int? cve_UsuChqDev { get; set; }

    public string? nom_UsuChqDev { get; set; }

    public int? cve_empaquePromo { get; set; }

    public string? LeyendaCOB { get; set; }

    public double? KgIniPromo { get; set; }

    public double? KgFinPromo { get; set; }

    public string? CuentaCobEdoCta { get; set; }

    public string? BancoCobEdoCta { get; set; }

    public string? EmailCobEdoCta { get; set; }

    public string? PermisoSCT { get; set; }

    public string? CveSAT_TipoPerm { get; set; }

    public int? Cve_TipoPermSAT { get; set; }

    public bool? EntregasAPP { get; set; }

    public double? VersionCCP { get; set; }

    public bool? GeneraCFDI4 { get; set; }

    public int? cve_EstatusTraNC { get; set; }

    public string? desc_EstatusTraNC { get; set; }

    public string? DirFotosGuias { get; set; }

    public long? ConsecCfdiTra { get; set; }
}
