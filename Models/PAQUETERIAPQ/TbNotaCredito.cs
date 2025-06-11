using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbNotaCredito
{
    public int CveNotaCredito { get; set; }

    public long? ConsecNc { get; set; }

    public string DescNotaCredito { get; set; } = null!;

    public double Importe { get; set; }

    public int CveCliente { get; set; }

    public string NomCliente { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public int CveUsuario { get; set; }

    public string NomUsuario { get; set; } = null!;

    public bool Tipo { get; set; }

    public DateTime FechaPago { get; set; }

    public string Direccion { get; set; } = null!;

    public string Colonia { get; set; } = null!;

    public string Poblacion { get; set; } = null!;

    public string Rfc { get; set; } = null!;
}
