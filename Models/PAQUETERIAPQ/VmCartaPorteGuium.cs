using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class VmCartaPorteGuium
{
    public long Id { get; set; }

    public string NoGuia { get; set; } = null!;

    public int? IdUnidad { get; set; }

    public int? IdChofer { get; set; }

    public long IdRemolque { get; set; }

    public string? UsoCfdi { get; set; }

    public byte FormaPago { get; set; }

    public string? MetodoPago { get; set; }

    public double Total { get; set; }

    public int OficinaOrigen { get; set; }

    public int OficinaDestino { get; set; }

    public string? NombreRem { get; set; }

    public string Rfcrem { get; set; } = null!;

    public string? NombreDes { get; set; }

    public string Rfcdes { get; set; } = null!;
}
