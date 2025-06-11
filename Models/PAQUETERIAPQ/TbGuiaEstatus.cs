using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbGuiaEstatus
{
    public long CveGuiaEstatus { get; set; }

    public long CveGuia { get; set; }

    public int CveEstatus { get; set; }

    public string? DescEstatus { get; set; }

    public int CveUsuario { get; set; }

    public string NomUsuario { get; set; } = null!;

    public int? CveOficina { get; set; }

    public DateTime? Fecha { get; set; }

    public double? Importe { get; set; }

    public long? CveReferencia { get; set; }

    public string? Referencia { get; set; }

    public string? Notas { get; set; }

    public DateTime? FechaComp { get; set; }

    public bool? Conciliado { get; set; }

    public double? Descuento { get; set; }

    public int? CveBanco { get; set; }

    public string? NomBanco { get; set; }

    public long? CveNotaCredito { get; set; }

    public string? Observaciones { get; set; }

    public long? CveMovCon { get; set; }

    public long? CveReferencia2 { get; set; }

    public DateTime? FechaCancela { get; set; }

    public string? Descripcion { get; set; }

    public bool? AvisoOcurre { get; set; }

    public int? CveUsuarioOri { get; set; }

    public int? CveUsuarioConf { get; set; }

    public string? RefePagoA { get; set; }

    public DateTime? FechaPagoA { get; set; }

    public long? CveReferencia3 { get; set; }

    public bool? Verificado { get; set; }

    public string? CuentaCte { get; set; }

    public string? CuentaAlv { get; set; }

    public long? CveContraRecibo { get; set; }

    public string? Descripcion2 { get; set; }

    public bool? Autorizado { get; set; }

    public string? Referencia2 { get; set; }

    public bool? NoCuadra { get; set; }

    public bool? NoEdoCta { get; set; }

    public string? NumNotaCaCr { get; set; }

    public decimal? SaldoGuia { get; set; }

    public byte? NumParcialidad { get; set; }

    public bool? TimbraPago { get; set; }

    public long? CvePagoBanco { get; set; }

    public bool? Revisado { get; set; }

    public bool? ErrorTimbra { get; set; }
}
