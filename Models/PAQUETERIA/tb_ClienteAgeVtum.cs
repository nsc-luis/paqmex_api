using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_ClienteAgeVtum
{
    public long cve_cliente { get; set; }

    public int cve_AgeVta { get; set; }

    public DateOnly fecha { get; set; }

    public int cve_UsuAsigna { get; set; }

    public string Nom_usuAsigna { get; set; } = null!;
}
