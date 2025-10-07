using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_GuiaExp
{
    public string? num_guia { get; set; }

    public string? prefijo { get; set; }

    public long? Consec { get; set; }

    public int cve_ofiOri { get; set; }

    public string desc_OfiOri { get; set; } = null!;

    public int cve_ofiDes { get; set; }

    public string desc_OfiDes { get; set; } = null!;

    public short cve_moneda { get; set; }

    public double tipocambio { get; set; }

    public long cve_ClienteRem { get; set; }

    public string nombreRem { get; set; } = null!;

    public string rfcRem { get; set; } = null!;

    public string direccionRem { get; set; } = null!;

    public string coloniaRem { get; set; } = null!;

    public int cve_ciudadRem { get; set; }

    public string ciudadRem { get; set; } = null!;

    public int cve_estadoRem { get; set; }

    public string estadoRem { get; set; } = null!;

    public string? telRem { get; set; }

    public long cve_ClienteDes { get; set; }

    public string nombreDes { get; set; } = null!;

    public string rfcDes { get; set; } = null!;

    public string direccionDes { get; set; } = null!;

    public string coloniaDes { get; set; } = null!;

    public int cve_ciudadDes { get; set; }

    public string ciudadDes { get; set; } = null!;

    public int cve_estadoDes { get; set; }

    public string estadoDes { get; set; } = null!;

    public string? telDes { get; set; }

    public long cve_ClientePaga { get; set; }

    public string nombrePaga { get; set; } = null!;

    public string rfcPaga { get; set; } = null!;

    public string direccionPaga { get; set; } = null!;

    public string coloniaPaga { get; set; } = null!;

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

    public string? FolioInternet { get; set; }

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

    public byte? Tipo1 { get; set; }

    public double? kgs1 { get; set; }

    public int? cve_empaque1 { get; set; }

    public string? desc_empaque1 { get; set; }

    public string? contenido1 { get; set; }

    public int? cantidad1 { get; set; }

    public byte? Tipo2 { get; set; }

    public double? kgs2 { get; set; }

    public int? cve_empaque2 { get; set; }

    public string? desc_empaque2 { get; set; }

    public string? contenido2 { get; set; }

    public int? cantidad2 { get; set; }

    public byte? Tipo3 { get; set; }

    public double? kgs3 { get; set; }

    public int? cve_empaque3 { get; set; }

    public string? desc_empaque3 { get; set; }

    public string? contenido3 { get; set; }

    public int? cantidad3 { get; set; }

    public byte? Tipo4 { get; set; }

    public double? kgs4 { get; set; }

    public int? cve_empaque4 { get; set; }

    public string? desc_empaque4 { get; set; }

    public string? contenido4 { get; set; }

    public int? cantidad4 { get; set; }

    public int? cve_estatus { get; set; }

    public string? Desc_estatus { get; set; }

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

    public double? kms { get; set; }

    public double? CargoCita { get; set; }

    public string? EmailRem { get; set; }

    public string? EmailDes { get; set; }

    public DateTime? FECHAENTREGA { get; set; }

    public double? ManDes { get; set; }

    public double? ManEst { get; set; }

    public bool? existeR { get; set; }

    public bool? existeD { get; set; }

    public bool? existeP { get; set; }

    public long? cve_remision { get; set; }

    public long? cve_guiaExp { get; set; }

    public long? cve_guia { get; set; }
}
