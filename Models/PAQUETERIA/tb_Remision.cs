using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_Remision
{
    public long Cve_remision { get; set; }

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

    public byte CondPago { get; set; }

    public int? cve_cobrador { get; set; }

    public string? nom_cobrador { get; set; }

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

    public bool? cita { get; set; }

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

    public string? NumIntPaga { get; set; }

    public string? NumExtPaga { get; set; }

    public string? CPPaga { get; set; }

    public bool? facturado { get; set; }

    public long? CVE_GUIA { get; set; }
}
