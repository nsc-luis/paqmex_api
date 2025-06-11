using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbNotaCaCrTemp
{
    public long CveNotaCaCr { get; set; }

    public string NumNotaCaCr { get; set; } = null!;

    public string Prefijo { get; set; } = null!;

    public long Consec { get; set; }

    public int CveOficina { get; set; }

    public string DescOficina { get; set; } = null!;

    public short CveMoneda { get; set; }

    public double Tipocambio { get; set; }

    public long CveCliente { get; set; }

    public string NombreCte { get; set; } = null!;

    public string RfcCte { get; set; } = null!;

    public string DireccionCte { get; set; } = null!;

    public string ColoniaCte { get; set; } = null!;

    public int CveCiudadCte { get; set; }

    public string CiudadCte { get; set; } = null!;

    public int CveEstadoCte { get; set; }

    public string EstadoCte { get; set; } = null!;

    public string? TelCte { get; set; }

    public double Iva { get; set; }

    public byte Tipo { get; set; }

    public double Total { get; set; }

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaCancela { get; set; }

    public bool Activa { get; set; }

    public int? CveUsuario { get; set; }

    public string? NomUsuario { get; set; }

    public long? NumeroAprobacion { get; set; }

    public int? AnoAprobacion { get; set; }

    public string? CadenaOriginal { get; set; }

    public string? Sello { get; set; }

    public string? NumIntCte { get; set; }

    public string? NumExtCte { get; set; }

    public string? Cpcte { get; set; }

    public string? Concepto { get; set; }

    public long? CveGuia { get; set; }

    public string? NumGuia { get; set; }

    public string? Autoriza { get; set; }

    public double? RetIva { get; set; }

    public string? FormaPagoCo { get; set; }

    public string? UniMedCo { get; set; }

    public byte? TipoComprobante { get; set; }

    public string? ObserCancela { get; set; }

    public string? UsoCfdi { get; set; }

    public string? MetodoPago { get; set; }
}
