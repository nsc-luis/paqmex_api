using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_empresa
{
    public string nombre { get; set; } = null!;

    public string direccion { get; set; } = null!;

    public string lugar { get; set; } = null!;

    public string representante { get; set; } = null!;

    public string? maniobras { get; set; }

    public double? IVA { get; set; }

    public double? RetIVA { get; set; }

    public double? RetISSS { get; set; }

    public double? RetIMSS { get; set; }

    public double? RendGasolina { get; set; }

    public double? SueldoPorKms { get; set; }

    public string? RFC { get; set; }

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

    public string? ArchivoCer { get; set; }

    public string? archivoKEY { get; set; }

    public string? PasswordLlave { get; set; }

    public string? NumeroCertificado { get; set; }

    public string? Certificado { get; set; }

    public string? RFCCertificado { get; set; }

    public string? Logo { get; set; }

    public string? Cedula { get; set; }

    public string? NUMEXT { get; set; }

    public string? NUMINT { get; set; }

    public int? CVE_CIUDAD { get; set; }

    public string? NOM_CIUDAD { get; set; }

    public int? CVE_ESTADO { get; set; }

    public string? NOM_ESTADO { get; set; }

    public string? CP { get; set; }

    public string? COLONIA { get; set; }

    public bool? EnviaMailGuia { get; set; }

    public string? Logo2 { get; set; }

    public bool? SeriesFacElec { get; set; }

    public DateTime? VigenciaDesde { get; set; }

    public DateTime? VigenciaHasta { get; set; }

    public double? VersionFacElec { get; set; }

    public int? cve_CuentaCob { get; set; }

    public double? VersionTaller { get; set; }

    public string? VersionXML { get; set; }

    public double? VERSIOnTRA { get; set; }

    public string? mensajeIni { get; set; }

    public bool? AutPagoParcial { get; set; }

    public long? ConsecPP { get; set; }

    public string? tels { get; set; }

    public string? UserTimbra { get; set; }

    public string? PassTimbra { get; set; }

    public string? NomServer { get; set; }

    public string? NomCorto { get; set; }

    public double? VersionRem { get; set; }

    public bool? TarifaXKgs { get; set; }

    public string? PASSPFX { get; set; }

    public int? CVE_EMPRESA { get; set; }

    public double? PorcSeguro { get; set; }

    public double? SeguroMin { get; set; }

    public string? ArchivoCER33 { get; set; }

    public string? ArchivoKEY33 { get; set; }

    public string? PasswordLlave33 { get; set; }

    public string? NomEmisor { get; set; }

    public string? RfcEmisor { get; set; }

    public string? SoftwareIDTimbra { get; set; }

    public string? AgenteIDTimbra { get; set; }

    public string? LeyendaSeg { get; set; }

    public string? Cve_Regimen { get; set; }

    public string? Desc_Regimen { get; set; }

    public string? ProdSatSeguro { get; set; }

    public string? UnidadMedidaSAT { get; set; }

    public DateOnly? FechaIniComPago { get; set; }

    public DateOnly? FechaFinComPago { get; set; }

    public string? ProdSATFlete { get; set; }

    public string? ProdSatFleteCC { get; set; }
}
