using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbEmpresaCert
{
    public DateTime? FechaIni { get; set; }

    public DateTime? FechaFin { get; set; }

    public string? NumeroCertificado { get; set; }

    public string? Certificado { get; set; }

    public string? ArchivoCer33 { get; set; }

    public string? ArchivoKey33 { get; set; }

    public string? PasswordLlave33 { get; set; }
}
