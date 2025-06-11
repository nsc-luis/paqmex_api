using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbViajeDetalle
{
    public long CveViajeDet { get; set; }

    public long CveViaje { get; set; }

    public long CveGuia { get; set; }

    public bool? Entregada { get; set; }

    public long? CveGuiaestatus { get; set; }

    public bool? VerificaEnt { get; set; }

    public string? NomUsuVerifica { get; set; }
}
