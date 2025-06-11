using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbGuiaTemp
{
    public long CveGuia { get; set; }

    public string NumGuia { get; set; } = null!;

    public string Prefijo { get; set; } = null!;

    public long Consec { get; set; }

    public int CveOfiOri { get; set; }

    public string DescOfiOri { get; set; } = null!;

    public int CveOfiDes { get; set; }

    public string DescOfiDes { get; set; } = null!;

    public short CveMoneda { get; set; }

    public double Tipocambio { get; set; }

    public long CveClienteRem { get; set; }

    public string? NombreRem { get; set; }

    public string RfcRem { get; set; } = null!;

    public string? DireccionRem { get; set; }

    public string? ColoniaRem { get; set; }

    public int CveCiudadRem { get; set; }

    public string CiudadRem { get; set; } = null!;

    public int CveEstadoRem { get; set; }

    public string EstadoRem { get; set; } = null!;

    public string? TelRem { get; set; }

    public long CveClienteDes { get; set; }

    public string? NombreDes { get; set; }

    public string RfcDes { get; set; } = null!;

    public string? DireccionDes { get; set; }

    public string? ColoniaDes { get; set; }

    public int CveCiudadDes { get; set; }

    public string CiudadDes { get; set; } = null!;

    public int CveEstadoDes { get; set; }

    public string EstadoDes { get; set; } = null!;

    public string? TelDes { get; set; }

    public long CveClientePaga { get; set; }

    public string? NombrePaga { get; set; }

    public string RfcPaga { get; set; } = null!;

    public string? DireccionPaga { get; set; }

    public string? ColoniaPaga { get; set; }

    public int CveCiudadPaga { get; set; }

    public string CiudadPaga { get; set; } = null!;

    public int CveEstadoPaga { get; set; }

    public string EstadoPaga { get; set; } = null!;

    public string? TelPaga { get; set; }

    public int CveMaterial { get; set; }

    public string? DescMaterial { get; set; }

    public short? Clase { get; set; }

    public string RecogerEn { get; set; } = null!;

    public string EntregarEn { get; set; } = null!;

    public double Flete { get; set; }

    public double OtrosCargos { get; set; }

    public double PorcSeguro { get; set; }

    public double Seguro { get; set; }

    public double Declarado { get; set; }

    public string? Poliza { get; set; }

    public double Recoleccion { get; set; }

    public double Entrega { get; set; }

    public string? Comanda { get; set; }

    public double RetIva { get; set; }

    public long Caja { get; set; }

    public double DescFlete { get; set; }

    public double Iva { get; set; }

    public string? Observaciones { get; set; }

    public string? Estante { get; set; }

    public byte FormaPago { get; set; }

    public int CveEmpRecibe { get; set; }

    public string NomEmpRecibe { get; set; } = null!;

    public int? CveEmpRecolecta { get; set; }

    public string? NomEmpRecolecta { get; set; }

    public string? PreGuia { get; set; }

    public byte TipoCarga { get; set; }

    public double Total { get; set; }

    public DateTime FechaAlta { get; set; }

    public bool Entregada { get; set; }

    public bool Activa { get; set; }

    public int? CveCamion { get; set; }

    public string? DescCamion { get; set; }

    public bool Ocurre { get; set; }

    public bool Foranea { get; set; }

    public double Saldo { get; set; }

    public int ActualizaObs { get; set; }

    public int CveGuiaEstatus { get; set; }

    public byte CondPago { get; set; }

    public int? CveCobrador { get; set; }

    public string? NomCobrador { get; set; }

    public int? CveGuiaEstatusRev { get; set; }

    public string FolioInternet { get; set; } = null!;

    public int? CveLiquidacion { get; set; }

    public DateTime? FechaCancela { get; set; }

    public double CuotaTon { get; set; }

    public int? CveOperador { get; set; }

    public string? NomOperador { get; set; }

    public int? CveEstibador { get; set; }

    public double? Maniobras { get; set; }

    public string? ObserMan { get; set; }

    public DateTime? FechaMan { get; set; }

    public int? CveManiobra { get; set; }

    public int? CveUsuario { get; set; }

    public string? NomUsuario { get; set; }

    public long? CveGuiaEstatusViaje { get; set; }

    public bool? Cita { get; set; }

    public bool? CargoOcurre { get; set; }

    public bool? Archivo { get; set; }

    public bool? Acuse { get; set; }

    public double? Kms { get; set; }

    public double? CargoCita { get; set; }

    public bool? Incobrable { get; set; }

    public bool? VerificaFlete { get; set; }

    public bool? AplicaManiobra { get; set; }

    public string? EmailRem { get; set; }

    public string? EmailDes { get; set; }

    public bool? MailEntrega { get; set; }

    public DateTime? Fechaentrega { get; set; }

    public double? ManDes { get; set; }

    public double? ManEst { get; set; }

    public int? CveEstatus { get; set; }

    public string? DescEstatus { get; set; }

    public long? NumeroAprobacion { get; set; }

    public int? AnoAprobacion { get; set; }

    public string? CadenaOriginal { get; set; }

    public string? Sello { get; set; }

    public string? NumIntPaga { get; set; }

    public string? NumExtPaga { get; set; }

    public string? Cppaga { get; set; }

    public long? CveGuiasus { get; set; }

    public long? CveRemision { get; set; }

    public bool? Digitalizada { get; set; }

    public int? CveCamionRecol { get; set; }

    public string? NumPreGuia { get; set; }

    public double? ValorMcia { get; set; }

    public int? CveDestOcurre { get; set; }

    public bool? Estibable { get; set; }

    public bool? RecibeSab { get; set; }

    public string? CodZona { get; set; }

    public string? FormaPagoCo { get; set; }

    public string? UniMedCo { get; set; }

    public string? CalleDes { get; set; }

    public int? CveSupervisor { get; set; }

    public string? NomSupervisor { get; set; }

    public byte? MotivoCancela { get; set; }

    public DateTime? FechaMarcaMan { get; set; }

    public double? SaldoPp { get; set; }

    public bool? Prepago { get; set; }

    public bool? RelPp { get; set; }

    public double? FleteOri { get; set; }

    public double? TotalOri { get; set; }

    public long? ConsecPp { get; set; }

    public bool? ExcEdoCta { get; set; }

    public byte? Tipo { get; set; }

    public double? Kgs { get; set; }

    public string? DireccionEmi { get; set; }

    public string? Numextemi { get; set; }

    public string? Numintemi { get; set; }

    public string? Coloniaemi { get; set; }

    public string? Cpemi { get; set; }

    public string? CiudadEmi { get; set; }

    public string? EstadoEmi { get; set; }

    public string? UsoCfdi { get; set; }

    public double? Cpac { get; set; }

    public string? MetodoPago { get; set; }

    public long? CveGuiaOri { get; set; }

    public string? NumGuiaOri { get; set; }

    public string? NombreOper { get; set; }

    public string? RfcOper { get; set; }

    public string? LicenciaOper { get; set; }

    public string? PlacaCamion { get; set; }

    public string? ModeloCamion { get; set; }

    public string? TipoCamionSat { get; set; }

    public string? PolizaCamion { get; set; }

    public string? AseguradoraCamion { get; set; }

    public string? TipoCajaSat { get; set; }

    public string? PlacaCaja { get; set; }

    public string? ColoniaSatOri { get; set; }

    public string? LocalidadSatOri { get; set; }

    public string? MunicipioSatOri { get; set; }

    public string? EstadoSatOri { get; set; }

    public string? ColoniaSatDes { get; set; }

    public string? LocalidadSatDes { get; set; }

    public string? MunicipioSatDes { get; set; }

    public string? EstadoSatDes { get; set; }

    public string? CpDes { get; set; }

    public bool? EsRecol { get; set; }

    public string? CveSatUniMedCcpsat { get; set; }

    public string? CpRem { get; set; }

    public string? CveSatRegimenFiscalPaga { get; set; }
}
