using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_NotaCaCrTemp
{
    public long Cve_NotaCaCr { get; set; }

    public string num_notaCaCr { get; set; } = null!;

    public string prefijo { get; set; } = null!;

    public long Consec { get; set; }

    public int cve_oficina { get; set; }

    public string desc_Oficina { get; set; } = null!;

    public short cve_moneda { get; set; }

    public double tipocambio { get; set; }

    public long cve_Cliente { get; set; }

    public string nombreCte { get; set; } = null!;

    public string rfcCte { get; set; } = null!;

    public string direccionCte { get; set; } = null!;

    public string coloniaCte { get; set; } = null!;

    public int cve_ciudadCte { get; set; }

    public string ciudadCte { get; set; } = null!;

    public int cve_estadoCte { get; set; }

    public string estadoCte { get; set; } = null!;

    public string? telCte { get; set; }

    public double IVA { get; set; }

    public byte Tipo { get; set; }

    public double total { get; set; }

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaCancela { get; set; }

    public bool Activa { get; set; }

    public int? cve_usuario { get; set; }

    public string? nom_usuario { get; set; }

    public long? NumeroAprobacion { get; set; }

    public int? AnoAprobacion { get; set; }

    public string? CadenaOriginal { get; set; }

    public string? Sello { get; set; }

    public string? NumIntCte { get; set; }

    public string? NumExtCte { get; set; }

    public string? CPCte { get; set; }

    public string? Concepto { get; set; }

    public long? cve_guia { get; set; }

    public string? num_guia { get; set; }

    public string? autoriza { get; set; }

    public double? RetIVA { get; set; }

    public string? FormaPagoCO { get; set; }

    public string? UniMedCO { get; set; }

    public byte? tipoComprobante { get; set; }

    public string? obserCancela { get; set; }

    public string? UsoCFDI { get; set; }

    public string? MetodoPago { get; set; }
}
