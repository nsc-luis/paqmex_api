using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class vmCartaPorteGuiaDetalle
{
    public long Id { get; set; }

    public string NoGuia { get; set; } = null!;

    public string? ClaveSAT { get; set; }

    public string? Descripcion { get; set; }

    public int? Cantidad { get; set; }

    public double? Peso { get; set; }

    public int Largo { get; set; }

    public int Ancho { get; set; }

    public bool? MaterialPeligroso { get; set; }

    public string CveMaterialPeligroso { get; set; } = null!;

    public string Embalaje { get; set; } = null!;
}
