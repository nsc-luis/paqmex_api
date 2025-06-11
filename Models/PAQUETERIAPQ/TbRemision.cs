using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbRemision
{
    public long CveRemision { get; set; }

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

    public byte CondPago { get; set; }

    public int? CveCobrador { get; set; }

    public string? NomCobrador { get; set; }

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

    public bool? Cita { get; set; }

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

    public string? NumIntPaga { get; set; }

    public string? NumExtPaga { get; set; }

    public string? Cppaga { get; set; }

    public bool? Facturado { get; set; }

    public long? CveGuia { get; set; }
}
