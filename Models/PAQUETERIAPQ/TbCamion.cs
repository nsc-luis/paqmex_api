using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbCamion
{
    public int CveCamion { get; set; }

    public string DescCamion { get; set; } = null!;

    public int CveOperador { get; set; }

    public int CvePropietario { get; set; }

    public int CveRuta { get; set; }

    public string CuentaContable { get; set; } = null!;

    public byte Tipo { get; set; }

    public string? Marca { get; set; }

    public string? Tipo2 { get; set; }

    public string? Modelo { get; set; }

    public string? Serie { get; set; }

    public string? Gps { get; set; }

    public string? Placa { get; set; }

    public byte? Ejes { get; set; }

    public DateTime? IniSeg { get; set; }

    public DateTime? VenceSeg { get; set; }

    public string? NoPoliza { get; set; }

    public double? KmInicial { get; set; }

    public double? KmMtto { get; set; }

    public double? KmAviso { get; set; }

    public double? KmRecorrido { get; set; }

    public int? CvePaquete { get; set; }

    public double? KmUltMtto { get; set; }

    public bool? Activo { get; set; }

    public int? CveOficina { get; set; }

    public string? Usuario { get; set; }

    public string? NomUsuario { get; set; }

    public DateTime? FechaBaja { get; set; }

    public string? Observaciones { get; set; }

    public string? TarjetaPista { get; set; }

    public string? CtaConPista { get; set; }

    public bool? Permisionario { get; set; }

    public int? CveDepto { get; set; }

    public string? DescDepto { get; set; }

    public int? CveCamionestatus { get; set; }

    public double? Cargamin { get; set; }

    public string? ObserBaja { get; set; }

    public string? NumTarjetaCir { get; set; }

    public DateTime? VenceTarjetaCir { get; set; }

    public int? CveAseg { get; set; }

    public byte? CausaBaja { get; set; }

    public bool? Ocurre { get; set; }

    public string? Foliobaja { get; set; }

    public int? Autorizaviaje { get; set; }

    public string? UsuAutoriza { get; set; }

    public bool? ViajePaq { get; set; }

    public bool? EnVenta { get; set; }

    public DateTime? VenceVerHumo { get; set; }

    public DateTime? VenceVerFisMec { get; set; }

    public DateTime? FechaUltModLl { get; set; }

    public double? Rendimiento { get; set; }

    public double? Litros { get; set; }

    public double? PesoMax { get; set; }

    public DateOnly? FechaObser { get; set; }

    public double? RendMax { get; set; }

    public byte? TipoPlaca { get; set; }

    public double? PesoMin { get; set; }

    public bool? Reseteo { get; set; }

    public byte? TipoComb { get; set; }

    public int? CveProveedor { get; set; }

    public string? NomProveedor { get; set; }

    public byte? Tipo3 { get; set; }

    public bool? SinReseteo { get; set; }

    public byte? EmpresaViaje { get; set; }

    public int? CveTipoCarroSat { get; set; }

    public string? CveSatTipoCarroSat { get; set; }

    public bool? EsPropietario { get; set; }

    public string? NoPolizaMa { get; set; }

    public int? CveAsegMa { get; set; }

    public string? CveSatParteTran { get; set; }

    public double? Peso { get; set; }

    public double? PesoBrutoMax { get; set; }
}
