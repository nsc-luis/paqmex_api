using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_Camion
{
    public int Cve_camion { get; set; }

    public string desc_camion { get; set; } = null!;

    public int cve_Operador { get; set; }

    public int cve_propietario { get; set; }

    public int cve_ruta { get; set; }

    public string cuenta_contable { get; set; } = null!;

    public byte tipo { get; set; }

    public string? Marca { get; set; }

    public string? Tipo2 { get; set; }

    public string? Modelo { get; set; }

    public string? Serie { get; set; }

    public string? GPS { get; set; }

    public string? Placa { get; set; }

    public byte? Ejes { get; set; }

    public DateTime? IniSeg { get; set; }

    public DateTime? VenceSeg { get; set; }

    public string? NoPoliza { get; set; }

    public double? KmInicial { get; set; }

    public double? KmMtto { get; set; }

    public double? KmAviso { get; set; }

    public double? KmRecorrido { get; set; }

    public int? cve_Paquete { get; set; }

    public double? KmUltMtto { get; set; }

    public bool? ACTIVO { get; set; }

    public int? cve_oficina { get; set; }

    public string? USUARIO { get; set; }

    public string? NOM_USUARIO { get; set; }

    public DateTime? FECHA_BAJA { get; set; }

    public string? OBSERVACIONES { get; set; }

    public string? TarjetaPista { get; set; }

    public string? CtaConPista { get; set; }

    public bool? PERMISIONARIO { get; set; }

    public int? cve_depto { get; set; }

    public string? desc_depto { get; set; }

    public int? CVE_CAMIONESTATUS { get; set; }

    public double? CARGAMIN { get; set; }

    public string? ObserBaja { get; set; }

    public string? NumTarjetaCir { get; set; }

    public DateTime? VenceTarjetaCir { get; set; }

    public int? cve_aseg { get; set; }

    public byte? CausaBaja { get; set; }

    public bool? OCURRE { get; set; }

    public string? Foliobaja { get; set; }

    public int? AUTORIZAVIAJE { get; set; }

    public string? UsuAutoriza { get; set; }

    public bool? ViajePaq { get; set; }

    public bool? EnVenta { get; set; }

    public DateTime? VenceVerHumo { get; set; }

    public DateTime? VenceVerFisMec { get; set; }

    public DateTime? FechaUltModLL { get; set; }

    public double? rendimiento { get; set; }

    public double? litros { get; set; }

    public double? PesoMax { get; set; }

    public DateOnly? FechaObser { get; set; }

    public double? RendMax { get; set; }

    public byte? TipoPlaca { get; set; }

    public double? PesoMin { get; set; }

    public bool? Reseteo { get; set; }

    public byte? TipoComb { get; set; }

    public int? cve_proveedor { get; set; }

    public string? nom_proveedor { get; set; }

    public byte? Tipo3 { get; set; }

    public bool? SinReseteo { get; set; }

    public byte? EmpresaViaje { get; set; }

    public int? cve_TipoCarroSAT { get; set; }

    public string? cveSAT_TipoCarroSAT { get; set; }

    public bool? EsPropietario { get; set; }

    public string? NoPolizaMA { get; set; }

    public int? cve_asegMA { get; set; }

    public string? cveSAT_ParteTran { get; set; }

    public double? peso { get; set; }

    public double? pesoBrutoMax { get; set; }
}
