using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbTarifaCte
{
    public long CveTarifa { get; set; }

    public long CveCliente { get; set; }

    public int CveOficinaOri { get; set; }

    public int CveOficinaDes { get; set; }

    public int? CveEmpaque { get; set; }

    public byte Tipo { get; set; }

    public double Tarifa { get; set; }

    public DateTime? Vigencia { get; set; }

    public DateTime? FechaAlta { get; set; }

    public byte? TipoCarga { get; set; }

    public int? Destinoant { get; set; }

    public double? Minimo { get; set; }

    public bool? Activo { get; set; }

    public byte? Estatus { get; set; }

    public double? Pesomax { get; set; }

    public bool? Revisado { get; set; }

    public double? CostoKgsExc { get; set; }
}
