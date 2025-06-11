using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbReporte
{
    public int CvePrograma { get; set; }

    public int Escala { get; set; }

    public string Lineas { get; set; } = null!;

    public string NumPag { get; set; } = null!;

    public string Encabezado { get; set; } = null!;

    public double MSup { get; set; }

    public double MInf { get; set; }

    public double MIzq { get; set; }

    public double MDer { get; set; }

    public double MEnc { get; set; }

    public double MPie { get; set; }

    public byte Papel { get; set; }

    public byte Orientacion { get; set; }
}
