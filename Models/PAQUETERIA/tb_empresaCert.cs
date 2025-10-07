using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_empresaCert
{
    public DateTime? FechaIni { get; set; }

    public DateTime? FechaFin { get; set; }

    public string? NumeroCertificado { get; set; }

    public string? Certificado { get; set; }

    public string? ArchivoCER33 { get; set; }

    public string? ArchivoKEY33 { get; set; }

    public string? PasswordLlave33 { get; set; }
}
