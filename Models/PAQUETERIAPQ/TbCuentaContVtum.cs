using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbCuentaContVtum
{
    public int CveOficina { get; set; }

    public string CuentaContV { get; set; } = null!;

    public string DescripcionV { get; set; } = null!;

    public string NombreV { get; set; } = null!;

    public string CuentaContF { get; set; } = null!;

    public string DescripcionF { get; set; } = null!;

    public string NombreF { get; set; } = null!;

    public string CuentaContRe { get; set; } = null!;

    public string DescripcionRe { get; set; } = null!;

    public string NombreRe { get; set; } = null!;

    public string CuentaContO { get; set; } = null!;

    public string DescripcionO { get; set; } = null!;

    public string NombreO { get; set; } = null!;

    public string CuentaContS { get; set; } = null!;

    public string DescripcionS { get; set; } = null!;

    public string NombreS { get; set; } = null!;

    public string CuentaContIva { get; set; } = null!;

    public string DescripcionIva { get; set; } = null!;

    public string NombreIva { get; set; } = null!;

    public string CuentaContRiva { get; set; } = null!;

    public string DescripcionRiva { get; set; } = null!;

    public string NombreRiva { get; set; } = null!;

    public string? DescCuentaContNcr { get; set; }

    public string? NomCuentaContNcr { get; set; }

    public string? CuentaContNcr { get; set; }
}
