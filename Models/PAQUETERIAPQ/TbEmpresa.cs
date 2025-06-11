using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbEmpresa
{
    public string Nombre { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Lugar { get; set; } = null!;

    public string Representante { get; set; } = null!;

    public string? Maniobras { get; set; }

    public double? Iva { get; set; }

    public double? RetIva { get; set; }

    public double? RetIsss { get; set; }

    public double? RetImss { get; set; }

    public double? RendGasolina { get; set; }

    public double? SueldoPorKms { get; set; }

    public string? Rfc { get; set; }

    public double? PorcVolumen { get; set; }

    public double? PorcDemora { get; set; }

    public double? PorcCitas { get; set; }

    public double? AltoCamion { get; set; }

    public double? AnchoCamion { get; set; }

    public double? LargoCamion { get; set; }

    public double? AltoCta { get; set; }

    public double? AnchoCta { get; set; }

    public double? LargoCta { get; set; }

    public string? KeyCob { get; set; }

    public float? Version { get; set; }

    public string? LigaRepInt { get; set; }

    public string? PathFotoCaja { get; set; }

    public string? PathFotoEmp { get; set; }

    public double? Fletecta { get; set; }

    public double? Fletecamion { get; set; }

    public double? SueldoPorKmsPaq { get; set; }

    public string? Mensaje { get; set; }

    public string? LinkRecol { get; set; }

    public double? FleteMetaLocal { get; set; }

    public double? FleteMetaForaneo { get; set; }

    public DateTime? FechaPagos { get; set; }

    public string? PwdCierrePagos { get; set; }

    public string? PwdAutLiq { get; set; }

    public string? PwdAutDiasV { get; set; }

    public string? Puerto { get; set; }

    public string? PathGuias { get; set; }

    public bool? Enviafoliocamara { get; set; }

    public string? Impresoraetiq { get; set; }

    public string? Puertousb { get; set; }

    public string? ArchivoCer { get; set; }

    public string? ArchivoKey { get; set; }

    public string? PasswordLlave { get; set; }

    public string? NumeroCertificado { get; set; }

    public string? Certificado { get; set; }

    public string? Rfccertificado { get; set; }

    public string? Logo { get; set; }

    public string? Cedula { get; set; }

    public string? Numext { get; set; }

    public string? Numint { get; set; }

    public int? CveCiudad { get; set; }

    public string? NomCiudad { get; set; }

    public int? CveEstado { get; set; }

    public string? NomEstado { get; set; }

    public string? Cp { get; set; }

    public string? Colonia { get; set; }

    public bool? EnviaMailGuia { get; set; }

    public string? Logo2 { get; set; }

    public bool? SeriesFacElec { get; set; }

    public DateTime? VigenciaDesde { get; set; }

    public DateTime? VigenciaHasta { get; set; }

    public double? VersionFacElec { get; set; }

    public int? CveCuentaCob { get; set; }

    public double? VersionTaller { get; set; }

    public string? VersionXml { get; set; }

    public double? VersionTra { get; set; }

    public string? MensajeIni { get; set; }

    public bool? AutPagoParcial { get; set; }

    public long? ConsecPp { get; set; }

    public string? Tels { get; set; }

    public string? UserTimbra { get; set; }

    public string? PassTimbra { get; set; }

    public string? NomServer { get; set; }

    public string? NomCorto { get; set; }

    public double? VersionRem { get; set; }

    public bool? TarifaXkgs { get; set; }

    public string? Passpfx { get; set; }

    public int? CveEmpresa { get; set; }

    public double? PorcSeguro { get; set; }

    public double? SeguroMin { get; set; }

    public string? ArchivoCer33 { get; set; }

    public string? ArchivoKey33 { get; set; }

    public string? PasswordLlave33 { get; set; }

    public string? NomEmisor { get; set; }

    public string? RfcEmisor { get; set; }

    public string? SoftwareIdtimbra { get; set; }

    public string? AgenteIdtimbra { get; set; }

    public string? LeyendaSeg { get; set; }

    public string? CveRegimen { get; set; }

    public string? DescRegimen { get; set; }

    public string? ProdSatSeguro { get; set; }

    public string? UnidadMedidaSat { get; set; }

    public DateOnly? FechaIniComPago { get; set; }

    public DateOnly? FechaFinComPago { get; set; }

    public string? ProdSatflete { get; set; }

    public string? ProdSatFleteCc { get; set; }

    public bool? DifRemDestPaga { get; set; }

    public string? DescFlete { get; set; }
}
