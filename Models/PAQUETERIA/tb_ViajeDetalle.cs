using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_ViajeDetalle
{
    public long cve_ViajeDet { get; set; }

    public long cve_viaje { get; set; }

    public long cve_guia { get; set; }

    public bool? Entregada { get; set; }

    public long? CVE_GUIAESTATUS { get; set; }

    public bool? VerificaEnt { get; set; }

    public string? Nom_UsuVerifica { get; set; }
}
