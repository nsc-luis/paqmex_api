using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbCaja
{
    public string NumCaja { get; set; } = null!;

    public string? Marca { get; set; }

    public double? Capacidad { get; set; }

    public string? Modelo { get; set; }

    public string? Serie { get; set; }

    public string? Gps { get; set; }

    public string? Placa { get; set; }

    public string? Longitud { get; set; }

    public byte? Ejes { get; set; }

    public string? Altura { get; set; }

    public string? Piso { get; set; }

    public DateTime? IniSeg { get; set; }

    public string? NoPoliza { get; set; }

    public DateTime? VenceSeg { get; set; }

    public byte? Nacionalidad { get; set; }

    public byte? CvePropietario { get; set; }

    public bool? LuzLat { get; set; }

    public bool? LuzFte { get; set; }

    public bool? LuzTra { get; set; }

    public bool? Reflejantes { get; set; }

    public bool? LuzAlto { get; set; }

    public bool? LuzPlaca { get; set; }

    public bool? EjesOk { get; set; }

    public bool? Frenos { get; set; }

    public bool? Patines { get; set; }

    public bool? Manivela { get; set; }

    public bool? Gomas { get; set; }

    public bool? Manitas { get; set; }

    public bool? Coples { get; set; }

    public bool? GuardaP { get; set; }

    public bool? Loderas { get; set; }

    public bool? LineasA { get; set; }

    public bool? BolsasA { get; set; }

    public bool? PortaLlanta { get; set; }

    public bool? LlantaRef { get; set; }

    public bool? Suspension { get; set; }

    public string? NumLlanta1 { get; set; }

    public string? NumLlanta2 { get; set; }

    public string? NumLlanta3 { get; set; }

    public string? NumLlanta4 { get; set; }

    public string? NumLlanta5 { get; set; }

    public string? NumLlanta6 { get; set; }

    public string? NumLlanta7 { get; set; }

    public string? NumLlanta8 { get; set; }

    public string? MarcaLlanta1 { get; set; }

    public string? MarcaLlanta2 { get; set; }

    public string? MarcaLlanta3 { get; set; }

    public string? MarcaLlanta4 { get; set; }

    public string? MarcaLlanta5 { get; set; }

    public string? MarcaLlanta6 { get; set; }

    public string? MarcaLlanta7 { get; set; }

    public string? MarcaLlanta8 { get; set; }

    public int? DesgaLlanta1 { get; set; }

    public int? DesgaLlanta2 { get; set; }

    public int? DesgaLlanta3 { get; set; }

    public int? DesgaLlanta4 { get; set; }

    public int? DesgaLlanta5 { get; set; }

    public int? DesgaLlanta6 { get; set; }

    public int? DesgaLlanta7 { get; set; }

    public int? DesgaLlanta8 { get; set; }

    public string? OriRec1 { get; set; }

    public string? OriRec2 { get; set; }

    public string? OriRec3 { get; set; }

    public string? OriRec4 { get; set; }

    public string? OriRec5 { get; set; }

    public string? OriRec6 { get; set; }

    public string? OriRec7 { get; set; }

    public string? OriRec8 { get; set; }

    public string? FotoFte { get; set; }

    public string? FotoTra { get; set; }

    public string? FotoDer { get; set; }

    public string? FotoIzq { get; set; }

    public string? SerieLlanta1 { get; set; }

    public string? SerieLlanta2 { get; set; }

    public string? SerieLlanta3 { get; set; }

    public string? SerieLlanta4 { get; set; }

    public string? SerieLlanta5 { get; set; }

    public string? SerieLlanta6 { get; set; }

    public string? SerieLlanta7 { get; set; }

    public string? SerieLlanta8 { get; set; }

    public long? CveCajaestatus { get; set; }

    public double? KmInicial { get; set; }

    public double? KmMtto { get; set; }

    public double? KmAviso { get; set; }

    public double? KmRecorrido { get; set; }

    public double? KmUltMtto { get; set; }

    public int? CvePaquete { get; set; }

    public int? CveOficina { get; set; }

    public byte? Tipo { get; set; }

    public string? Descripcion { get; set; }

    public string? Observaciones { get; set; }

    public bool? Activa { get; set; }

    public string? Usuario { get; set; }

    public string? NomUsuario { get; set; }

    public DateTime? FechaBaja { get; set; }

    public string? ObserBaja { get; set; }

    public byte? CausaBaja { get; set; }

    public string? FolioBaja { get; set; }

    public bool? EnVenta { get; set; }

    public DateTime? FechaUltModLl { get; set; }

    public double? Hrsactual { get; set; }

    public byte? TipoPlaca { get; set; }

    public DateTime? FechaObser { get; set; }

    public string? ObserNoViaje { get; set; }

    public int? CveTipoRemolSat { get; set; }

    public string? CveSatTipoRemolSat { get; set; }

    public double? Peso { get; set; }
}
