using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbConceptoVtaAct
{
    public int CveConcepto { get; set; }

    public string? DescConcepto { get; set; }

    public bool? Gravable { get; set; }

    public string? CveProdServSat { get; set; }

    public string? DescProdServSat { get; set; }

    public string? UniMed { get; set; }
}
