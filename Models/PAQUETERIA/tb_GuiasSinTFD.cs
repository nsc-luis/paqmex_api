﻿using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_GuiasSinTFD
{
    public long cve_guia { get; set; }

    public string? num_guia { get; set; }

    public string? SelloSAT { get; set; }

    public string? UUID { get; set; }

    public DateTime? FechaTimbre { get; set; }

    public string? Certificado { get; set; }

    public string? CertificadoSAT { get; set; }

    public string? xml { get; set; }

    public string? tfd { get; set; }

    public string? cadenaOriTFD { get; set; }

    public DateTime? FechaCancela { get; set; }

    public int? EstatusCancela { get; set; }

    public string? XmlOri { get; set; }

    public string? xmlcancela { get; set; }
}
