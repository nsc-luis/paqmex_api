using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbConfigura
{
    public string Nombre { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Lugar { get; set; } = null!;

    public string RepresentanteQuitar { get; set; } = null!;

    public string? Maniobras { get; set; }

    public double? Iva { get; set; }

    public double? RetIva { get; set; }

    public double? RetIsss { get; set; }

    public double? RetImss { get; set; }

    public double? RendGasolina { get; set; }

    public double? SueldoPorKms { get; set; }

    public string? RfcQuitar { get; set; }

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

    public string? ArchivoCerQuitar { get; set; }

    public string? ArchivoKeyQuitar { get; set; }

    public string? PasswordLlaveQuitar { get; set; }

    public string? NumeroCertificadoQuitar { get; set; }

    public string? CertificadoQuitar { get; set; }

    public string? RfccertificadoQuitar { get; set; }

    public string? LogoQuitar { get; set; }

    public string? CedulaQuitar { get; set; }

    public string? NumextQuitar { get; set; }

    public string? NumintQuitar { get; set; }

    public int? CveCiudadQuitar { get; set; }

    public string? NomCiudadQuitar { get; set; }

    public int? CveEstadoQuitar { get; set; }

    public string? NomEstadoQuitar { get; set; }

    public string? CpQuitar { get; set; }

    public string? ColoniaQuitar { get; set; }

    public bool? EnviaMailGuia { get; set; }

    public string? Logo2 { get; set; }

    public bool? SeriesFacElec { get; set; }

    public DateTime? VigenciaDesdeQuitar { get; set; }

    public DateTime? VigenciaHastaQuitar { get; set; }

    public double? VersionFacElec { get; set; }

    public int? CveCuentaCob { get; set; }

    public double? VersionTaller { get; set; }

    public string? VersionXml { get; set; }

    public double? VersionTra { get; set; }

    public string? MensajeIni { get; set; }

    public bool? AutPagoParcial { get; set; }

    public long? ConsecPp { get; set; }

    public string? TelsQuitar { get; set; }

    public string? NomCorto { get; set; }

    public bool? PistasAut { get; set; }

    public double? VersionCtrlD { get; set; }

    public string? MsgIni { get; set; }

    public double? VersionDigitaliza { get; set; }

    public double? PorcProdQuim { get; set; }

    public long? CveClienteTarMinCon { get; set; }

    public double? TipoCambio { get; set; }

    public DateOnly? FechaTipoCambio { get; set; }

    public bool? PwdPortal { get; set; }

    public double? PorcCpac { get; set; }

    public bool? MostrarEntApp { get; set; }

    public byte? CopiasImpGuia { get; set; }

    public byte? MesesCapNdisel { get; set; }

    public byte? CveEmpresa { get; set; }

    public string? NomEmpresa { get; set; }

    public bool? Timbrar { get; set; }

    public int? CveUsuChqDev { get; set; }

    public string? NomUsuChqDev { get; set; }

    public int? CveEmpaquePromo { get; set; }

    public string? LeyendaCob { get; set; }

    public double? KgIniPromo { get; set; }

    public double? KgFinPromo { get; set; }

    public string? CuentaCobEdoCta { get; set; }

    public string? BancoCobEdoCta { get; set; }

    public string? EmailCobEdoCta { get; set; }

    public string? PermisoSct { get; set; }

    public string? CveSatTipoPerm { get; set; }

    public int? CveTipoPermSat { get; set; }

    public bool? EntregasApp { get; set; }

    public double? VersionCcp { get; set; }

    public bool? GeneraCfdi4 { get; set; }

    public int? CveEstatusTraNc { get; set; }

    public string? DescEstatusTraNc { get; set; }

    public string? DirFotosGuias { get; set; }

    public long? ConsecCfdiTra { get; set; }
}
