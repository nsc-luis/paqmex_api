using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_NotaCaCrTimbre
{
    public long cve_NotaCaCr { get; set; }

    public string? num_NotaCaCr { get; set; }

    public string? SelloSAT { get; set; }

    public string? UUID { get; set; }

    public DateTime? FechaTimbre { get; set; }

    public string? Certificado { get; set; }

    public string? CertificadoSAT { get; set; }

    public string? xml { get; set; }

    public string? tfd { get; set; }

    public string? cadenaOriTFD { get; set; }

    public string? XmlOri { get; set; }

    public string? selloCfdi { get; set; }

    public string? desc_EstatusCancela { get; set; }

    public DateTime? FechaCancela { get; set; }

    public int? EstatusCancela { get; set; }

    public byte[]? QrCode { get; set; }

    public string? AcuseCancela { get; set; }

    public byte[]? PDF { get; set; }
}
