using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_Cliente
{
    public long Cve_Cliente { get; set; }

    public byte cve_oficina { get; set; }

    public byte cve_ofiCre { get; set; }

    public int? cve_AgeVta { get; set; }

    public int cve_ciudad { get; set; }

    public int cve_estado { get; set; }

    public string? nombre { get; set; }

    public string direccion { get; set; } = null!;

    public string? colonia { get; set; }

    public string? cp { get; set; }

    public string rfc { get; set; } = null!;

    public string? tel1 { get; set; }

    public string? tel2 { get; set; }

    public string? email { get; set; }

    public byte condPago { get; set; }

    public int? cve_cobrador { get; set; }

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

    public DateTime fechaAlta { get; set; }

    public long cve_UltEntrega { get; set; }

    public bool Foranea { get; set; }

    public bool activo { get; set; }

    public bool? efectivo { get; set; }

    public bool? seguro { get; set; }

    public string? poliza { get; set; }

    public string? NomCte { get; set; }

    public string? ApePat { get; set; }

    public string? ApeMat { get; set; }

    public bool? cita { get; set; }

    public bool? CteTrafico { get; set; }

    public bool? CteRecol { get; set; }

    public int? cve_EjeCta { get; set; }

    public bool? BuroCR { get; set; }

    public int? CVE_BANCO { get; set; }

    public bool? TRANSFERENCIA { get; set; }

    public string? DIASTRAN { get; set; }

    public byte? PRORROGA { get; set; }

    public int? cve_EjeCob { get; set; }

    public int? CVE_USUARIO { get; set; }

    public string? NOM_USUARIO { get; set; }

    public bool? NOENT { get; set; }

    public bool? NOREC { get; set; }

    public string? DescDocAnexo { get; set; }

    public int? Cve_EjeCtaVta { get; set; }

    public string? emailCC { get; set; }

    public string? emailEmb { get; set; }

    public string? emailEmbCC { get; set; }

    public string? OBSERVACIONES { get; set; }

    public string? CLASIFICACION { get; set; }

    public bool? MostrarAgeVta { get; set; }

    public double? LimiteCred { get; set; }

    public double? OTROS { get; set; }

    public string? NUMEXT { get; set; }

    public string? NUMINT { get; set; }

    public bool? VISIBLE { get; set; }

    public double? FleteMinimo { get; set; }

    public byte? CausaBaja { get; set; }

    public DateOnly? FechaBaja { get; set; }

    public bool? PERDIDA { get; set; }

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

    public string? leyendaGuia { get; set; }

    public DateTime? FechaAgeVta { get; set; }

    public double? VtaMax { get; set; }

    public byte? TipoPago { get; set; }

    public string? CuentaPago { get; set; }

    public int? cve_colonia { get; set; }

    public int? cve_direccion { get; set; }

    public byte? FormaPagoCte { get; set; }

    public string? DiasTranNom { get; set; }

    public bool? PaqMex { get; set; }

    public bool? facAbierto { get; set; }

    public bool? NoCorreoDoc { get; set; }

    public bool? DocRemDes { get; set; }

    public bool? RevEmail { get; set; }

    public bool? CobroEmail { get; set; }

    public bool? NoRecConv { get; set; }

    public bool? NoEntConv { get; set; }

    public bool? encuestar { get; set; }

    public string? ClasifVtas { get; set; }

    public double? MontoMinSem { get; set; }

    public double? MontoMinMes { get; set; }

    public bool? frecuente { get; set; }

    public double? PorcRecol { get; set; }

    public double? PorcEntrega { get; set; }

    public long? ClientePP { get; set; }

    public bool? RevConvPzs { get; set; }

    public bool? RevConvKgs { get; set; }

    public string? Cuadrante { get; set; }

    public int? Cve_EjeSeg { get; set; }

    public double? IncFlete { get; set; }

    public byte? CondPago2 { get; set; }

    public bool? DelCredCC { get; set; }

    public DateOnly? FechaDelCredCC { get; set; }

    public double? MontoCita { get; set; }

    public bool? NoCobrarRec { get; set; }

    public bool? NoCobrarEnt { get; set; }

    public bool? REVISADO { get; set; }

    public int? cve_giro { get; set; }

    public string? desc_giro { get; set; }

    public int? cve_ciudadRC { get; set; }

    public int? cve_estadoRC { get; set; }

    public string? direccionRC { get; set; }

    public string? coloniaRC { get; set; }

    public string? CPRC { get; set; }

    public bool? NoEnviaXC { get; set; }

    public string? HorarioCobro { get; set; }

    public bool? ChequeDev { get; set; }

    public bool? EnvioAcuse { get; set; }

    public double? PorcFacDoc { get; set; }

    public string? PwdInternet { get; set; }

    public bool? NoCPAC { get; set; }

    public string? cve_UsoCFDI { get; set; }

    public string? desc_UsoCFDI { get; set; }

    public bool? TimbraRev { get; set; }

    public bool? DocGuiaCont { get; set; }

    public double? PorcCPAC { get; set; }

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

    public string? CveSAT_Colonia { get; set; }

    public string? CveSAT_Localidad { get; set; }

    public string? CveSAT_Municipio { get; set; }

    public string? CveSAT_Estado { get; set; }

    public string? cveSAT_RegimenFiscal { get; set; }

    public bool? CodPostalRecol { get; set; }

    public string? cve_SATUsoCFDI { get; set; }

    public bool? ReqEnt { get; set; }

    public string? desc_ReqEnt { get; set; }

    public bool? BajoPrecio { get; set; }

    public byte? sistema { get; set; }

    public bool? FacConCCP { get; set; }
}
