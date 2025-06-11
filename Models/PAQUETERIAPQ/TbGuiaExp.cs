using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbGuiaExp
{
    public string? NumGuia { get; set; }

    public string? Prefijo { get; set; }

    public long? Consec { get; set; }

    public int CveOfiOri { get; set; }

    public string DescOfiOri { get; set; } = null!;

    public int CveOfiDes { get; set; }

    public string DescOfiDes { get; set; } = null!;

    public short CveMoneda { get; set; }

    public double Tipocambio { get; set; }

    public long CveClienteRem { get; set; }

    public string NombreRem { get; set; } = null!;

    public string RfcRem { get; set; } = null!;

    public string DireccionRem { get; set; } = null!;

    public string ColoniaRem { get; set; } = null!;

    public int CveCiudadRem { get; set; }

    public string CiudadRem { get; set; } = null!;

    public int CveEstadoRem { get; set; }

    public string EstadoRem { get; set; } = null!;

    public string? TelRem { get; set; }

    public long CveClienteDes { get; set; }

    public string NombreDes { get; set; } = null!;

    public string RfcDes { get; set; } = null!;

    public string DireccionDes { get; set; } = null!;

    public string ColoniaDes { get; set; } = null!;

    public int CveCiudadDes { get; set; }

    public string CiudadDes { get; set; } = null!;

    public int CveEstadoDes { get; set; }

    public string EstadoDes { get; set; } = null!;

    public string? TelDes { get; set; }

    public long CveClientePaga { get; set; }

    public string NombrePaga { get; set; } = null!;

    public string RfcPaga { get; set; } = null!;

    public string DireccionPaga { get; set; } = null!;

    public string ColoniaPaga { get; set; } = null!;

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

    public string? FolioInternet { get; set; }

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

    public byte? Tipo1 { get; set; }

    public double? Kgs1 { get; set; }

    public int? CveEmpaque1 { get; set; }

    public string? DescEmpaque1 { get; set; }

    public string? Contenido1 { get; set; }

    public int? Cantidad1 { get; set; }

    public byte? Tipo2 { get; set; }

    public double? Kgs2 { get; set; }

    public int? CveEmpaque2 { get; set; }

    public string? DescEmpaque2 { get; set; }

    public string? Contenido2 { get; set; }

    public int? Cantidad2 { get; set; }

    public byte? Tipo3 { get; set; }

    public double? Kgs3 { get; set; }

    public int? CveEmpaque3 { get; set; }

    public string? DescEmpaque3 { get; set; }

    public string? Contenido3 { get; set; }

    public int? Cantidad3 { get; set; }

    public byte? Tipo4 { get; set; }

    public double? Kgs4 { get; set; }

    public int? CveEmpaque4 { get; set; }

    public string? DescEmpaque4 { get; set; }

    public string? Contenido4 { get; set; }

    public int? Cantidad4 { get; set; }

    public int? CveEstatus { get; set; }

    public string? DescEstatus { get; set; }

    public byte? TipoPersonaR { get; set; }

    public bool? ForaneaR { get; set; }

    public string? NomCteR { get; set; }

    public string? ApePatR { get; set; }

    public string? ApeMatR { get; set; }

    public byte? TipoPersonaD { get; set; }

    public bool? ForaneaD { get; set; }

    public string? NomCteD { get; set; }

    public string? ApePatD { get; set; }

    public string? ApeMatD { get; set; }

    public byte? TipoPersonaP { get; set; }

    public bool? ForaneaP { get; set; }

    public string? NomCteP { get; set; }

    public string? ApePatP { get; set; }

    public string? ApeMatP { get; set; }

    public double? Kms { get; set; }

    public double? CargoCita { get; set; }

    public string? EmailRem { get; set; }

    public string? EmailDes { get; set; }

    public DateTime? Fechaentrega { get; set; }

    public double? ManDes { get; set; }

    public double? ManEst { get; set; }

    public bool? ExisteR { get; set; }

    public bool? ExisteD { get; set; }

    public bool? ExisteP { get; set; }

    public long? CveRemision { get; set; }

    public long? CveGuiaExp { get; set; }

    public long? CveGuia { get; set; }
}
