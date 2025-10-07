using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_GuiaEstatus
{
    public long cve_guiaEstatus { get; set; }

    public long Cve_guia { get; set; }

    public int Cve_estatus { get; set; }

    public string? Desc_estatus { get; set; }

    public int Cve_usuario { get; set; }

    public string Nom_usuario { get; set; } = null!;

    public int? cve_oficina { get; set; }

    public DateTime? Fecha { get; set; }

    public double? Importe { get; set; }

    public long? cve_referencia { get; set; }

    public string? referencia { get; set; }

    public string? Notas { get; set; }

    public DateTime? FechaComp { get; set; }

    public bool? Conciliado { get; set; }

    public double? descuento { get; set; }

    public int? cve_banco { get; set; }

    public string? nom_banco { get; set; }

    public long? cve_NotaCredito { get; set; }

    public string? Observaciones { get; set; }

    public long? cve_MovCon { get; set; }

    public long? cve_referencia2 { get; set; }

    public DateTime? FechaCancela { get; set; }

    public string? Descripcion { get; set; }

    public bool? AvisoOcurre { get; set; }

    public int? Cve_UsuarioOri { get; set; }

    public int? Cve_UsuarioConf { get; set; }

    public string? RefePagoA { get; set; }

    public DateTime? FechaPagoA { get; set; }

    public long? CVE_REFERENCIA3 { get; set; }

    public bool? VERIFICADO { get; set; }

    public string? CuentaCte { get; set; }

    public string? CuentaALV { get; set; }

    public long? Cve_ContraRecibo { get; set; }

    public string? descripcion2 { get; set; }

    public bool? autorizado { get; set; }

    public string? referencia2 { get; set; }

    public bool? NoCuadra { get; set; }

    public bool? NoEdoCta { get; set; }

    public string? num_notaCaCr { get; set; }

    public decimal? SaldoGuia { get; set; }

    public byte? NumParcialidad { get; set; }

    public bool? TimbraPago { get; set; }

    public long? cve_PagoBanco { get; set; }

    public bool? revisado { get; set; }

    public bool? ErrorTimbra { get; set; }
}
