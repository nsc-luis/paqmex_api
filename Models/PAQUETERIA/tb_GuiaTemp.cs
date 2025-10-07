using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_GuiaTemp
{
    public long Cve_Guia { get; set; }

    public string num_guia { get; set; } = null!;

    public string prefijo { get; set; } = null!;

    public long Consec { get; set; }

    public int cve_ofiOri { get; set; }

    public string desc_OfiOri { get; set; } = null!;

    public int cve_ofiDes { get; set; }

    public string desc_OfiDes { get; set; } = null!;

    public short cve_moneda { get; set; }

    public double tipocambio { get; set; }

    public long cve_ClienteRem { get; set; }

    public string? nombreRem { get; set; }

    public string rfcRem { get; set; } = null!;

    public string? direccionRem { get; set; }

    public string? coloniaRem { get; set; }

    public int cve_ciudadRem { get; set; }

    public string ciudadRem { get; set; } = null!;

    public int cve_estadoRem { get; set; }

    public string estadoRem { get; set; } = null!;

    public string? telRem { get; set; }

    public long cve_ClienteDes { get; set; }

    public string? nombreDes { get; set; }

    public string rfcDes { get; set; } = null!;

    public string? direccionDes { get; set; }

    public string? coloniaDes { get; set; }

    public int cve_ciudadDes { get; set; }

    public string ciudadDes { get; set; } = null!;

    public int cve_estadoDes { get; set; }

    public string estadoDes { get; set; } = null!;

    public string? telDes { get; set; }

    public long cve_ClientePaga { get; set; }

    public string? nombrePaga { get; set; }

    public string rfcPaga { get; set; } = null!;

    public string? direccionPaga { get; set; }

    public string? coloniaPaga { get; set; }

    public int cve_ciudadPaga { get; set; }

    public string ciudadPaga { get; set; } = null!;

    public int cve_estadoPaga { get; set; }

    public string estadoPaga { get; set; } = null!;

    public string? telPaga { get; set; }

    public int cve_Material { get; set; }

    public string? desc_material { get; set; }

    public short? Clase { get; set; }

    public string recogerEn { get; set; } = null!;

    public string EntregarEn { get; set; } = null!;

    public double Flete { get; set; }

    public double OtrosCargos { get; set; }

    public double PorcSeguro { get; set; }

    public double Seguro { get; set; }

    public double Declarado { get; set; }

    public string? poliza { get; set; }

    public double recoleccion { get; set; }

    public double entrega { get; set; }

    public string? comanda { get; set; }

    public double RetIVA { get; set; }

    public long caja { get; set; }

    public double DescFlete { get; set; }

    public double IVA { get; set; }

    public string? observaciones { get; set; }

    public string? estante { get; set; }

    public byte FormaPago { get; set; }

    public int cve_empRecibe { get; set; }

    public string nom_empRecibe { get; set; } = null!;

    public int? cve_empRecolecta { get; set; }

    public string? nom_EmpRecolecta { get; set; }

    public string? preGuia { get; set; }

    public byte TipoCarga { get; set; }

    public double total { get; set; }

    public DateTime FechaAlta { get; set; }

    public bool Entregada { get; set; }

    public bool Activa { get; set; }

    public int? cve_camion { get; set; }

    public string? desc_camion { get; set; }

    public bool Ocurre { get; set; }

    public bool Foranea { get; set; }

    public double Saldo { get; set; }

    public int actualizaObs { get; set; }

    public int cve_GuiaEstatus { get; set; }

    public byte CondPago { get; set; }

    public int? cve_cobrador { get; set; }

    public string? nom_cobrador { get; set; }

    public int? Cve_GuiaEstatusRev { get; set; }

    public string FolioInternet { get; set; } = null!;

    public int? cve_liquidacion { get; set; }

    public DateTime? FechaCancela { get; set; }

    public double CuotaTon { get; set; }

    public int? cve_operador { get; set; }

    public string? nom_operador { get; set; }

    public int? cve_estibador { get; set; }

    public double? maniobras { get; set; }

    public string? ObserMan { get; set; }

    public DateTime? FechaMan { get; set; }

    public int? cve_maniobra { get; set; }

    public int? cve_usuario { get; set; }

    public string? nom_usuario { get; set; }

    public long? cve_GuiaEstatusViaje { get; set; }

    public bool? cita { get; set; }

    public bool? CargoOcurre { get; set; }

    public bool? Archivo { get; set; }

    public bool? Acuse { get; set; }

    public double? kms { get; set; }

    public double? CargoCita { get; set; }

    public bool? INCOBRABLE { get; set; }

    public bool? VerificaFlete { get; set; }

    public bool? AplicaManiobra { get; set; }

    public string? EmailRem { get; set; }

    public string? EmailDes { get; set; }

    public bool? MailEntrega { get; set; }

    public DateTime? FECHAENTREGA { get; set; }

    public double? ManDes { get; set; }

    public double? ManEst { get; set; }

    public int? CVE_ESTATUS { get; set; }

    public string? DESC_ESTATUS { get; set; }

    public long? NumeroAprobacion { get; set; }

    public int? AnoAprobacion { get; set; }

    public string? CadenaOriginal { get; set; }

    public string? Sello { get; set; }

    public string? NumIntPaga { get; set; }

    public string? NumExtPaga { get; set; }

    public string? CPPaga { get; set; }

    public long? CVE_GUIASUS { get; set; }

    public long? cve_remision { get; set; }

    public bool? Digitalizada { get; set; }

    public int? cve_camionRecol { get; set; }

    public string? NumPreGuia { get; set; }

    public double? ValorMcia { get; set; }

    public int? cve_DestOcurre { get; set; }

    public bool? estibable { get; set; }

    public bool? RecibeSab { get; set; }

    public string? CodZona { get; set; }

    public string? FormaPagoCO { get; set; }

    public string? UniMedCO { get; set; }

    public string? CalleDes { get; set; }

    public int? cve_supervisor { get; set; }

    public string? nom_supervisor { get; set; }

    public byte? motivoCancela { get; set; }

    public DateTime? FechaMarcaMan { get; set; }

    public double? SaldoPP { get; set; }

    public bool? Prepago { get; set; }

    public bool? RelPP { get; set; }

    public double? FleteOri { get; set; }

    public double? TotalOri { get; set; }

    public long? ConsecPP { get; set; }

    public bool? ExcEdoCta { get; set; }

    public byte? Tipo { get; set; }

    public double? Kgs { get; set; }

    public string? direccionEMI { get; set; }

    public string? NUMEXTemi { get; set; }

    public string? NUMINTemi { get; set; }

    public string? COLONIAemi { get; set; }

    public string? CPemi { get; set; }

    public string? CiudadEmi { get; set; }

    public string? estadoEmi { get; set; }

    public string? UsoCFDI { get; set; }

    public double? CPAC { get; set; }

    public string? MetodoPago { get; set; }

    public long? cve_GuiaOri { get; set; }

    public string? num_GuiaOri { get; set; }

    public string? NombreOper { get; set; }

    public string? RfcOper { get; set; }

    public string? LicenciaOper { get; set; }

    public string? PlacaCamion { get; set; }

    public string? ModeloCamion { get; set; }

    public string? TipoCamionSAT { get; set; }

    public string? PolizaCamion { get; set; }

    public string? AseguradoraCamion { get; set; }

    public string? TipoCajaSat { get; set; }

    public string? PlacaCaja { get; set; }

    public string? coloniaSatOri { get; set; }

    public string? localidadSatOri { get; set; }

    public string? municipioSatOri { get; set; }

    public string? estadoSatOri { get; set; }

    public string? coloniaSatDes { get; set; }

    public string? localidadSatDes { get; set; }

    public string? municipioSatDes { get; set; }

    public string? estadoSatDes { get; set; }

    public string? CpDes { get; set; }

    public bool? EsRecol { get; set; }

    public string? cveSAT_UniMedCCPSAT { get; set; }

    public string? CpRem { get; set; }

    public string? cveSAT_RegimenFiscalPaga { get; set; }
}
