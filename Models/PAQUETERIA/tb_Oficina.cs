using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_Oficina
{
    public byte Cve_Oficina { get; set; }

    public string desc_oficina { get; set; } = null!;

    public string direccion { get; set; } = null!;

    public int cve_ciudad { get; set; }

    public int cve_estado { get; set; }

    public string? cuentaIVA { get; set; }

    public int? PesoMin { get; set; }

    public double ImporteMin { get; set; }

    public double CuotaTonelada { get; set; }

    public double CuotaForanea { get; set; }

    public bool Matriz { get; set; }

    public string? tels { get; set; }

    public long consecNC { get; set; }

    public long ConsecComanda { get; set; }

    public bool Activo { get; set; }

    public int PrefijoCamion { get; set; }

    public byte grupo { get; set; }

    public int? cve_usuGerente { get; set; }

    public int? Cve_UsuAutViaje { get; set; }

    public int? Cve_ConceptoGto { get; set; }

    public string? PREFIJO { get; set; }

    public int? CVE_SERIEFAC { get; set; }

    public int? CVE_SERIENC { get; set; }

    public string? NUMEXT { get; set; }

    public string? NUMINT { get; set; }

    public string? COLONIA { get; set; }

    public string? CP { get; set; }

    public int? cve_serieNCa { get; set; }

    public string? servidor { get; set; }

    public byte? CVE_ESTATUSCOB { get; set; }

    public int? MAIN { get; set; }

    public int? CVE_DESTINO { get; set; }

    public string? abreviatura { get; set; }

    public long? Cve_SerieFac2 { get; set; }

    public long? Cve_SerieNC2 { get; set; }

    public int? Cve_SerieSus { get; set; }

    public double? PesoMinRE { get; set; }

    public double? PesoMinFlete { get; set; }

    public double? Recol { get; set; }

    public double? Entrega { get; set; }

    public double? PorcRecol { get; set; }

    public double? PorcEntrega { get; set; }

    public byte? cve_OriTarKgs { get; set; }

    public byte? OrdenCtrlDIso { get; set; }

    public string? Cve_nomina { get; set; }

    public int? Dep_nomina { get; set; }

    public string? CuentaEmp { get; set; }

    public int? CVE_EMPRESA { get; set; }

    public int? cve_respCont { get; set; }

    public string? nom_respCont { get; set; }

    public bool? pagina { get; set; }

    public string? nom_oficinaPag { get; set; }

    public byte? Clasif { get; set; }

    public byte? OrdenRep { get; set; }

    public int? cve_zona { get; set; }

    public byte? OrdenVtasDest { get; set; }

    public bool? MapaPortal { get; set; }

    public string? DirPortal { get; set; }

    public bool? OrigenPortal { get; set; }

    public string? NomPortal { get; set; }

    public int? CantOper { get; set; }

    public int? CVE_ZONAHORARIO { get; set; }

    public int? cve_serieVal { get; set; }

    public double? KgMinSemana { get; set; }

    public double? KgMinSabado { get; set; }

    public int? UnidadesReq { get; set; }

    public int? EstatusCobro { get; set; }

    public string? LATITUD { get; set; }

    public string? LONGITUD { get; set; }

    public int? Cve_EmpRep { get; set; }

    public int? RecolPortal { get; set; }

    public string? CveSAT_Colonia { get; set; }

    public string? CveSAT_Localidad { get; set; }

    public string? CveSAT_Municipio { get; set; }

    public string? CveSAT_Estado { get; set; }
}
