using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbGuiaTimbre
{
    public long CveGuia { get; set; }

    public string? NumGuia { get; set; }

    public string? SelloSat { get; set; }

    public string? Uuid { get; set; }

    public DateTime? FechaTimbre { get; set; }

    public string? Certificado { get; set; }

    public string? CertificadoSat { get; set; }

    public string? Xml { get; set; }

    public string? Tfd { get; set; }

    public string? CadenaOriTfd { get; set; }

    public DateTime? FechaCancela { get; set; }

    public int? EstatusCancela { get; set; }

    public string? XmlOri { get; set; }

    public string? Xmlcancela { get; set; }

    public string? SelloCfdi { get; set; }

    public byte[]? Pdf { get; set; }

    public string? DescEstatusCancela { get; set; }

    public byte[]? QrCode { get; set; }

    public string? AcuseCancela { get; set; }
}
