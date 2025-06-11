using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbCliente
{
    public long CveCliente { get; set; }

    public byte CveOficina { get; set; }

    public byte CveOfiCre { get; set; }

    public int? CveAgeVta { get; set; }

    public int CveCiudad { get; set; }

    public int CveEstado { get; set; }

    public string? Nombre { get; set; }

    public string Direccion { get; set; } = null!;

    public string? Colonia { get; set; }

    public string? Cp { get; set; }

    public string Rfc { get; set; } = null!;

    public string? Tel1 { get; set; }

    public string? Tel2 { get; set; }

    public string? Email { get; set; }

    public byte CondPago { get; set; }

    public int? CveCobrador { get; set; }

    public double Recoleccion { get; set; }

    public double Entrega { get; set; }

    public double DescEntrega { get; set; }

    public byte TipoPersona { get; set; }

    public double DescFlete { get; set; }

    public string DiasCobro { get; set; } = null!;

    public string DiasRev { get; set; } = null!;

    public bool FormaPago { get; set; }

    public bool Nacional { get; set; }

    public bool SdoVencido { get; set; }

    public double TarifaEsp { get; set; }

    public bool Doctos { get; set; }

    public string? PersonaPago { get; set; }

    public string? PersonaEmb { get; set; }

    public DateTime FechaAlta { get; set; }

    public long CveUltEntrega { get; set; }

    public bool Foranea { get; set; }

    public bool Activo { get; set; }

    public bool? Efectivo { get; set; }

    public bool? Seguro { get; set; }

    public string? Poliza { get; set; }

    public string? NomCte { get; set; }

    public string? ApePat { get; set; }

    public string? ApeMat { get; set; }

    public bool? Cita { get; set; }

    public bool? CteTrafico { get; set; }

    public bool? CteRecol { get; set; }

    public int? CveEjeCta { get; set; }

    public bool? BuroCr { get; set; }

    public int? CveBanco { get; set; }

    public bool? Transferencia { get; set; }

    public string? Diastran { get; set; }

    public byte? Prorroga { get; set; }

    public int? CveEjeCob { get; set; }

    public int? CveUsuario { get; set; }

    public string? NomUsuario { get; set; }

    public bool? Noent { get; set; }

    public bool? Norec { get; set; }

    public string? DescDocAnexo { get; set; }

    public int? CveEjeCtaVta { get; set; }

    public string? EmailCc { get; set; }

    public string? EmailEmb { get; set; }

    public string? EmailEmbCc { get; set; }

    public string? Observaciones { get; set; }

    public string? Clasificacion { get; set; }

    public bool? MostrarAgeVta { get; set; }

    public double? LimiteCred { get; set; }

    public double? Otros { get; set; }

    public string? Numext { get; set; }

    public string? Numint { get; set; }

    public bool? Visible { get; set; }

    public double? FleteMinimo { get; set; }

    public byte? CausaBaja { get; set; }

    public DateOnly? FechaBaja { get; set; }

    public bool? Perdida { get; set; }

    public bool? DescNoReal { get; set; }

    public bool? ConfirmarEnt { get; set; }

    public bool? RecibeSab { get; set; }

    public DateTime? FechaLlama { get; set; }

    public string? ContactoLlama { get; set; }

    public bool? ConvConfuso { get; set; }

    public double? ConvCompromiso { get; set; }

    public byte? ConvClasif { get; set; }

    public double? TarifaCita { get; set; }

    public bool? Moroso { get; set; }

    public bool? TardaRec { get; set; }

    public bool? NoRecRem { get; set; }

    public bool? NoEntRem { get; set; }

    public string? LeyendaGuia { get; set; }

    public DateTime? FechaAgeVta { get; set; }

    public double? VtaMax { get; set; }

    public byte? TipoPago { get; set; }

    public string? CuentaPago { get; set; }

    public int? CveColonia { get; set; }

    public int? CveDireccion { get; set; }

    public byte? FormaPagoCte { get; set; }

    public string? DiasTranNom { get; set; }

    public bool? PaqMex { get; set; }

    public bool? FacAbierto { get; set; }

    public bool? NoCorreoDoc { get; set; }

    public bool? DocRemDes { get; set; }

    public bool? RevEmail { get; set; }

    public bool? CobroEmail { get; set; }

    public bool? NoRecConv { get; set; }

    public bool? NoEntConv { get; set; }

    public bool? Encuestar { get; set; }

    public string? ClasifVtas { get; set; }

    public double? MontoMinSem { get; set; }

    public double? MontoMinMes { get; set; }

    public bool? Frecuente { get; set; }

    public double? PorcRecol { get; set; }

    public double? PorcEntrega { get; set; }

    public long? ClientePp { get; set; }

    public bool? RevConvPzs { get; set; }

    public bool? RevConvKgs { get; set; }

    public string? Cuadrante { get; set; }

    public int? CveEjeSeg { get; set; }

    public double? IncFlete { get; set; }

    public byte? CondPago2 { get; set; }

    public bool? DelCredCc { get; set; }

    public DateOnly? FechaDelCredCc { get; set; }

    public double? MontoCita { get; set; }

    public bool? NoCobrarRec { get; set; }

    public bool? NoCobrarEnt { get; set; }

    public bool? Revisado { get; set; }

    public int? CveGiro { get; set; }

    public string? DescGiro { get; set; }

    public int? CveCiudadRc { get; set; }

    public int? CveEstadoRc { get; set; }

    public string? DireccionRc { get; set; }

    public string? ColoniaRc { get; set; }

    public string? Cprc { get; set; }

    public bool? NoEnviaXc { get; set; }

    public string? HorarioCobro { get; set; }

    public bool? ChequeDev { get; set; }

    public bool? EnvioAcuse { get; set; }

    public double? PorcFacDoc { get; set; }

    public string? PwdInternet { get; set; }

    public bool? NoCpac { get; set; }

    public string? CveUsoCfdi { get; set; }

    public string? DescUsoCfdi { get; set; }

    public bool? TimbraRev { get; set; }

    public bool? DocGuiaCont { get; set; }

    public double? PorcCpac { get; set; }

    public string? EmailPagos { get; set; }

    public double? VtaProMes { get; set; }

    public bool? Legal { get; set; }

    public string? ExpedienteBuro { get; set; }

    public string? ExpedienteLegal { get; set; }

    public byte? TipoCte { get; set; }

    public string? SitioWeb { get; set; }

    public bool? PrecioEspecial { get; set; }

    public double? PrecioMinKm { get; set; }

    public byte? EmpresaDoc { get; set; }

    public bool? RastreoCte { get; set; }

    public string? CveSatColonia { get; set; }

    public string? CveSatLocalidad { get; set; }

    public string? CveSatMunicipio { get; set; }

    public string? CveSatEstado { get; set; }

    public string? CveSatRegimenFiscal { get; set; }

    public bool? CodPostalRecol { get; set; }

    public string? CveSatusoCfdi { get; set; }

    public bool? ReqEnt { get; set; }

    public string? DescReqEnt { get; set; }

    public bool? BajoPrecio { get; set; }

    public byte? Sistema { get; set; }

    public bool? FacConCcp { get; set; }
}
