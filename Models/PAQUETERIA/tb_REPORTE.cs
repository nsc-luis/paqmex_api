using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_REPORTE
{
    public int Cve_programa { get; set; }

    public int escala { get; set; }

    public string lineas { get; set; } = null!;

    public string NumPag { get; set; } = null!;

    public string Encabezado { get; set; } = null!;

    public double mSup { get; set; }

    public double mInf { get; set; }

    public double mIzq { get; set; }

    public double mDer { get; set; }

    public double mEnc { get; set; }

    public double mPie { get; set; }

    public byte Papel { get; set; }

    public byte Orientacion { get; set; }
}
